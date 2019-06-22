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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace P2PSocket
{
    public partial class TalkForm : Form
    {
        public TalkForm()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            bs_Friend.DataSource = dat_Friends;
            bs_TalkkingMessage.DataSource = dat_TalkingMessage;
            StartTalk(tb_ip.Text, Convert.ToInt32(tb_port.Text));


        }
        BindingList<Friend> dat_Friends = new BindingList<Friend>();
        public class Friend
        {
            public string UserName { get; set; }
            public string IP { get; set; }


        }

        BindingList<TalkMessage> dat_TalkingMessage = new BindingList<TalkMessage>();
        public class TalkMessage
        {
            public string UserName { get; }
            public string Content { get; }

            public DateTime MessageTime { get; }

            public JObject MessageData
            {
                get
                {
                    return _MessageData;
                }
                set
                {
                    _MessageData = value;
                }
            }

            private JObject _MessageData = null;
        }
        #region 通讯有关的部分
        TcpClient tc = null;
        UdpClient udp = null;
        private void StartTalk(string IP, Int32 Port)
        {
            tc = new TcpClient();
            tc.Connect(IPAddress.Parse(IP), Port);






            JObject ToSend = new JObject();
            ToSend["UserName"] = tb_username.Text;
            ToSend["Pwd"] = tb_password.Text;
            ToSend["Command"] = "Login";
            MessageLib.SocketMessage sm = new MessageLib.SocketMessage(tc);
            sm.OnReceiveMessage += sm_OnReceiveMessage;
            sm.OnSendError += sm_OnSendError;
            sm.OnReceiveError += sm_OnReceiveError;
            SocketError se = new SocketError();
            IAsyncResult R = tc.Client.BeginReceive(sm.MessageIndex, 0, 4, SocketFlags.None, out se, sm.SizeReceiveCallBack, tc);

            sm.SendContent(ToSend);




        }

        void sm_OnReceiveError(JObject newmessage, TcpClient tc, MessageLib.SocketMessage skm)
        {
            throw new NotImplementedException();
        }

        void sm_OnSendError(JObject newmessage, TcpClient tc, MessageLib.SocketMessage skm)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 主要的消息处理逻辑
        /// </summary>
        /// <param name="newmessage"></param>
        /// <param name="tc"></param>
        /// <param name="skm"></param>
        void sm_OnReceiveMessage(JObject newmessage, TcpClient tc, MessageLib.SocketMessage skm)
        {
            if (newmessage["Status"].ToString() != "Success")
            {
                MessageBox.Show("登录失败," + newmessage["Status"].ToString());

            }
            else
            {
                this.Invoke(new Action(() =>
                {

                    Btn_Start.Enabled = false;
                }));


                if (newmessage["Command"].ToString() == "Login")
                {
                    foreach (var item in newmessage["Frends"])
                    {
                        this.Invoke(new Action(() =>
                        {
                            Friend fr = new Friend();
                            fr.IP = item["IP"].ToString();
                            fr.UserName = item["UserName"].ToString();
                            dat_Friends.Add(fr);
                        }));

                    }
                }
                else if (newmessage["Command"].ToString() == "TalkFrom")
                {
                    TalkMessage newm = new TalkMessage();
                    newm.MessageData = newmessage;

                }
                else if (newmessage["Command"].ToString() == "FriendLogin")
                {
                    this.Invoke(new Action(() =>
                    {
                        Friend fnd = dat_Friends.SingleOrDefault(t => t.UserName == newmessage["FrendUserName"].ToString());
                        fnd.IP = newmessage["IP"].ToString();

                    }));
                }
                //请求UDP开洞(P2P传输)
                else if (newmessage["Command"].ToString() == "OpenHole")
                {
                    udp = new UdpClient();
                    this.Invoke(new Action(() =>
                    {
                        udp.Connect(IPAddress.Parse(tb_ip.Text), Convert.ToInt32(tb_port.Text));
                        JObject SendInf = new JObject();
                        SendInf["Command"] = "UpdateUDF";
                        byte[] buf = Encoding.UTF8.GetBytes(SendInf.ToString());
                        udp.Send(BitConverter.GetBytes(buf.Length), 4);
                        udp.Send(buf, buf.Length);
                    }));


                }


            }

        }


        static UdpClient uc = null;

        #endregion

        private void btn_send_Click(object sender, EventArgs e)
        {
            JObject ToSend = new JObject();
            ToSend["Command"] = DateTime.Now.ToString("TalkTo");
            ToSend["SendTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff");
            ToSend["Content"] = tb_content.Text;
            ToSend["ToFendID"] = "";
            MessageLib.SocketMessage sm = new MessageLib.SocketMessage(tc);
            sm.SendContent(ToSend);
        }

        private void Btn_UDPSend_Click(object sender, EventArgs e)
        {

        }

        private void gv_frend_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                string UserName = ((Friend)(((DataGridView)sender).SelectedRows[0]).DataBoundItem).UserName;
                

            }
        }



    }
}
