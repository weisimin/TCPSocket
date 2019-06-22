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

            data_TalkingMessage.Columns.Add("UserName", typeof(string));
            data_TalkingMessage.Columns.Add("MessageTime", typeof(DateTime));
            data_TalkingMessage.Columns.Add("Content", typeof(string));
            data_TalkingMessage.Columns.Add("RawJson", typeof(JObject));

        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            bs_Friend.DataSource = data_Friends;
            bs_TalkkingMessage.DataSource = data_TalkingMessage;
            StartTalk(tb_ip.Text, Convert.ToInt32(tb_port.Text));


        }
        BindingList<Friend> data_Friends = new BindingList<Friend>();
        public class Friend
        {
            public string UserName { get; set; }
            public string IP { get; set; }

            public string OnLine { get; set; }
        }

        DataTable data_TalkingMessage = new DataTable();

        #region 通讯有关的部分
        TcpClient tcpc = null;
        UdpClient udpc = null;
        private void StartTalk(string IP, Int32 Port)
        {
            if (tcpc == null)
            {
                tcpc = new TcpClient();
                tcpc.Connect(IPAddress.Parse(IP), Port);
            }








            JObject ToSend = new JObject();
            ToSend["UserName"] = tb_username.Text;
            ToSend["Pwd"] = tb_password.Text;
            ToSend["Command"] = "Login";
            MessageLib.SocketMessage sm = new MessageLib.SocketMessage(tcpc);
            sm.OnReceiveMessage += sm_OnReceiveMessage;
            sm.OnSendError += sm_OnSendError;
            sm.OnReceiveError += sm_OnReceiveError;
            SocketError se = new SocketError();
            IAsyncResult R = tcpc.Client.BeginReceive(sm.MessageIndex, 0, 4, SocketFlags.None, out se, sm.SizeReceiveCallBack, tcpc);

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


                if (newmessage["Command"].ToString() == "ImLogin")
                {
                    foreach (var item in newmessage["Friends"])
                    {
                        this.Invoke(new Action(() =>
                        {
                            Friend fr = new Friend();
                            fr.IP = item["IP"].ToString();
                            if (fr.IP != "")
                            {
                                fr.OnLine = "是";
                            }
                            else
                            {
                                fr.OnLine = "否";
                            }
                            fr.UserName = item["UserName"].ToString();
                            data_Friends.Add(fr);
                            this.Refresh(); 
                        }));

                    }
                }
                else if (newmessage["Command"].ToString() == "TalkFrom")
                {
                    DataRow dr = data_TalkingMessage.NewRow();
                    dr.SetField("RawJson", newmessage);
                    dr.SetField("UserName", newmessage["TalkFromUserName"].ToString());
                    dr.SetField("Content", newmessage["Content"].ToString());
                    dr.SetField("MessageTime",Convert.ToDateTime( newmessage["MessageTime"].ToString()));
                    data_TalkingMessage.Rows.Add(dr);
                    this.Invoke(new Action(() => {
                        this.Refresh();
                    }));
                }
                else if (newmessage["Command"].ToString() == "TalkToError")
                {
                    MessageBox.Show("与" + newmessage["UserName"] + "的聊天内容:" + Environment.NewLine + newmessage["Content"]+Environment.NewLine+"对方没有收到");

                }
                else if (newmessage["Command"].ToString() == "FriendLogin")
                {
                    this.Invoke(new Action(() =>
                    {
                        Friend fnd = data_Friends.SingleOrDefault(t => t.UserName == newmessage["FriendUserName"].ToString());
                        fnd.IP = newmessage["IP"].ToString();
                        fnd.OnLine = "是";
                        this.Refresh(); 
                    }));
                }
                //请求UDP开洞(P2P传输)
                else if (newmessage["Command"].ToString() == "OpenHole")
                {
                    udpc = new UdpClient();
                    this.Invoke(new Action(() =>
                    {
                        udpc.Connect(IPAddress.Parse(tb_ip.Text), Convert.ToInt32(tb_port.Text));
                        JObject SendInf = new JObject();
                        SendInf["Command"] = "UpdateUDF";
                        byte[] buf = Encoding.UTF8.GetBytes(SendInf.ToString());
                        udpc.Send(BitConverter.GetBytes(buf.Length), 4);
                        udpc.Send(buf, buf.Length);
                    }));


                }
                //P2P连接
                else if (newmessage["Command"].ToString() == "P2PConnectTo")
                {
                    udpc = new UdpClient();



                }


            }

        }




        #endregion

        private void btn_send_Click(object sender, EventArgs e)
        {
            JObject ToSend = new JObject();
            ToSend["Command"] = DateTime.Now.ToString("TalkTo");
            ToSend["MessageTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ToSend["Content"] = tb_content.Text;
            ToSend["TalkToUserName"] = TalkingUserName;
            MessageLib.SocketMessage sm = new MessageLib.SocketMessage(tcpc);
            sm.SendContent(ToSend);
        }

        private void Btn_UDPSend_Click(object sender, EventArgs e)
        {

        }
        string TalkingUserName = "";
        private void gv_Friend_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                TalkingUserName = ((Friend)(((DataGridView)sender).SelectedRows[0]).DataBoundItem).UserName;
                bs_TalkkingMessage.Filter = "UserName='" + TalkingUserName + "'";
                gb_talking.Text = "与" + TalkingUserName + "聊天中";
            }
        }
    }
}
