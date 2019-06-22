using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Security;
using System.Threading;
namespace P2PServer
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();

        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            gv_statusdata.DataSource = OnLineInf;
            Thread listent = new Thread(new ParameterizedThreadStart(StartListen));
            listent.Start(new Object[] { tb_ip.Text, Convert.ToInt32(tb_port.Text) });


        }

        void StatusForm_OnReceiveMessage()
        {

        }
        #region 监听和检测断线

        public class OnLineData
        {
            public string IP { get; set; }
            public Int32 Port { get; set; }

            public TcpClient tcpl
            {
                get { return _tcpl; }
                set
                {
                    _tcpl = value;
                    _skm = new MessageLib.SocketMessage(_tcpl);

                }
            }

            private TcpClient _tcpl;
            public MessageLib.SocketMessage skm { get { return _skm; } }
            private MessageLib.SocketMessage _skm = null;

            public Guid UserID { get; set; }
            public string UserName { get; set; }

            public Int32 P2pPort { get; set; }
        }
        private BindingList<OnLineData> OnLineInf = new BindingList<OnLineData>();
        /// <summary>
        /// P2P通讯，开洞借用端口
        /// </summary>
        UdpClient ucl = null;
        private void StartListen(Object StartParams)
        {
            try
            {



                string IP = ((StartParams as object[])[0]).ToString();
                Int32 Port = Convert.ToInt32((StartParams as object[])[1]);

                TcpListener tcl = new TcpListener(IPAddress.Parse(IP), Port);

                ucl = new UdpClient(new IPEndPoint(IPAddress.Parse(IP), Port));


                tcl.Start();
                while (true)
                {
                    TcpClient tc = tcl.AcceptTcpClient();
                    tc.SendTimeout = 10000;
                    OnAcceptDo(tc);
                }
            }
            catch (Exception AnyError)
            {
                Console.WriteLine(AnyError.Message);
                Console.WriteLine(AnyError.StackTrace);
            }
        }

        private void OnAcceptDo(TcpClient tc)
        {
            OnLineData newc = new OnLineData();
            newc.IP = ((IPEndPoint)tc.Client.RemoteEndPoint).Address.ToString();
            newc.Port = ((IPEndPoint)tc.Client.RemoteEndPoint).Port;
            newc.tcpl = tc;

            this.Invoke(new Action(() =>
            {
                OnLineInf.Add(newc);
            }));


            SocketError se = new SocketError();
            MessageLib.SocketMessage sm = new MessageLib.SocketMessage(tc);
            sm.OnReceiveMessage += sm_OnReceiveMessage;
            sm.OnReceiveError += sm_OnReceiveError;
            sm.OnSendError += sm_OnSendError;
            IAsyncResult R = tc.Client.BeginReceive(sm.MessageIndex, 0, 4, SocketFlags.None, out se, sm.SizeReceiveCallBack, tc);


        }

        static void sm_OnSendError(JObject newmessage, TcpClient tc, MessageLib.SocketMessage skm)
        {
            throw new NotImplementedException();
        }

        static void sm_OnReceiveError(JObject newmessage, TcpClient tc, MessageLib.SocketMessage skm)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 主要的消息处理逻辑
        /// </summary>
        /// <param name="newmessage"></param>
        /// <param name="ReceiveTc"></param>
        /// <param name="Receiveskm"></param>
        void sm_OnReceiveMessage(Newtonsoft.Json.Linq.JObject newmessage, TcpClient ReceiveTc, MessageLib.SocketMessage Receiveskm)
        {
            if (newmessage["Command"].ToString() == "Login")
            {
                string UserName = newmessage["UserName"].ToString();
                string Pwd = newmessage["Pwd"].ToString();
                bool LoginR = System.Web.Security.Membership.ValidateUser(UserName, Pwd);
                JObject r = new JObject();
                MembershipUser msr = Membership.GetUser(UserName);
                if (msr == null)
                {
                    r["Status"] = "用户名" + UserName + "，不存在";
                }

                else if (msr.IsLockedOut == true)
                {
                    r["Status"] = "用户名" + UserName + "，密码错误次数太多,需由管理员处理";
                }
                else if (LoginR == false)
                {
                    r["Status"] = "用户密码不符";
                }
                else
                {
                    r["Status"] = "Success";


                    #region "多处登录，踢出"
                    OnLineData ToKill = OnLineInf.SingleOrDefault(t => t.UserID == (Guid)msr.ProviderUserKey);
                    if (ToKill != null)
                    {
                        JObject sr = new JObject();
                        sr["Status"] = "账号已在其他地方登录";
                        ToKill.skm.SendContent(sr);
                    }
                    #endregion

                    OnLineData ToUpd = OnLineInf.SingleOrDefault(t => t.tcpl == ReceiveTc);

                    ToUpd.UserID = (Guid)msr.ProviderUserKey;
                    ToUpd.UserName = msr.UserName;





                    ServerData.dbDataContext db = new ServerData.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
                    r["Command"] = "ImLogin";
                    //取得好友
                    var Friends = db.aspnet_Friendship.Where(t => t.aspnet_UserID == (Guid)msr.ProviderUserKey);
                    r["Friends"] = new JArray();
                    foreach (var Frienditem in Friends)
                    {
                        MembershipUser msu = Membership.GetUser(Frienditem.FriendaspnetID);
                        JObject JFriend = new JObject();
                        JFriend["UserName"] = msu.UserName.ToLower();

                        OnLineData old = OnLineInf.SingleOrDefault(t => t.UserID == (Guid)msu.ProviderUserKey);
                        if (old != null)
                        {
                            JFriend["IP"] = old.IP;
                            JFriend["Port"] = old.Port;
                            JFriend["OnLine"] = true;
                        }
                        else
                        {
                            JFriend["IP"] = "";
                            JFriend["Port"] = "";
                            JFriend["OnLine"] = false;
                        }




                        (r["Friends"] as JArray).Add(JFriend);

                    }
                    //通知好友上线
                    var belFriends = db.aspnet_Friendship.Where(t => t.FriendaspnetID == (Guid)msr.ProviderUserKey);
                    foreach (var Frienditem in belFriends)
                    {
                        OnLineData tonotice = OnLineInf.SingleOrDefault(t => t.UserID == Frienditem.aspnet_UserID);
                        if (tonotice != null)
                        {
                            JObject ToSendMessage = new JObject();
                            ToSendMessage["Status"] = "Success";
                            ToSendMessage["Command"] = "FriendLogin";
                            ToSendMessage["FriendUserName"] = msr.UserName.ToLower();
                            ToSendMessage["IP"] = ((IPEndPoint)ReceiveTc.Client.RemoteEndPoint).Address.ToString();
                            tonotice.skm.SendContent(ToSendMessage);
                        }
                    }

                }
                Receiveskm.SendContent(r);
                this.Invoke(new Action(()=>{
                    this.Refresh();
                }));
               ;
            }
            //服务器转发通讯
            else if (newmessage["Command"].ToString() == "TalkTo")
            {
                MembershipUser tomsr = Membership.GetUser(newmessage["TalkToUserName"].ToString());
                OnLineData old = OnLineInf.SingleOrDefault(t => t.UserID == (Guid)tomsr.ProviderUserKey);
                OnLineData SayFrom=OnLineInf.SingleOrDefault(t=>t.tcpl==ReceiveTc);
                if (old != null)
                {
                    newmessage["Command"] = "TalkFrom";
                    newmessage["Status"] = "Success";
                    newmessage["TalkFromUserName"] = SayFrom.UserName;
                    old.skm.SendContent(newmessage);
                }
                else
                {
                    JObject rtnr = new JObject();
                    rtnr["Command"] = "TalkToError";
                    rtnr["Status"] = "Success";
                    rtnr["UserName"] = newmessage["TakeToUserName"].ToString();
                    rtnr["Content"] = newmessage["Content"].ToString();
                    Receiveskm.SendContent(rtnr);
                }

            }
            //获取P2P的UDP端口
            else if (newmessage["Command"].ToString() == "GetUDPHoleInf")
            {
                MembershipUser tomsr = Membership.GetUser(newmessage["UserName"].ToString());
                OnLineData tofind = OnLineInf.SingleOrDefault(t => t.UserID == (Guid)tomsr.ProviderUserKey);
                JObject tor = new JObject();
                tor["Command"] = "GetUDPHoleInf";
                tor["Status"] = "Success";
                tor["P2PPort"] = tofind == null ? "" : tofind.P2pPort.ToString();
                Receiveskm.SendContent(tor);

            }

        }





        #endregion

        private void MI_UserManager_Click(object sender, EventArgs e)
        {
            UserSetting us = new UserSetting();
            us.SetMode("Modify");
            us.ShowDialog();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {

        }

        private void MI_NewUser_Click(object sender, EventArgs e)
        {
            UserSetting us = new UserSetting();
            us.SetMode("New");
            us.ShowDialog();
        }
    }
}
