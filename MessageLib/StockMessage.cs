using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace MessageLib
{
    public class SocketMessage
    {
        public SocketMessage(TcpClient tc)
        {
            _ConCli = tc;
            this.OnReceiveMessage += SocketMessage_OnReceiveMessage;
            this.OnReceiveError += SocketMessage_OnReceiveError;
            this.OnSendError += SocketMessage_OnSendError;
        }

        void SocketMessage_OnSendError(JObject newmessage, TcpClient tc, SocketMessage skm)
        {

        }

        void SocketMessage_OnReceiveError(JObject newmessage, TcpClient tc, SocketMessage skm)
        {

        }

        void SocketMessage_OnReceiveMessage(JObject newmessage, TcpClient tc, SocketMessage skm)
        {

        }

        public TcpClient ConCli { get { return _ConCli; } }
        private TcpClient _ConCli = null;
        public byte[] MessageIndex = new byte[4];
        public byte[] MessageContent = null;
        public void SizeReceiveCallBack(IAsyncResult result)
        {

            TcpClient tc = result.AsyncState as TcpClient;
            try
            {
                tc.Client.EndReceive(result);
            }
            catch (Exception ex)
            {

                return;
            }
            MessageContent = new byte[BitConverter.ToInt32(MessageIndex, 0)];
            SocketError se = new SocketError();
            tc.Client.BeginReceive(MessageContent, 0, MessageContent.Length, SocketFlags.None, out se, DataReceiveCallBack, tc); ;
        }
        private void DataReceiveCallBack(IAsyncResult result)
        {

            TcpClient tc = result.AsyncState as TcpClient;
            try
            {
                tc.Client.EndReceive(result);
            }
            catch (Exception ex)
            {

                return;
            }
            JObject str_newmessage = JObject.Parse(Encoding.UTF8.GetString(MessageContent));


            OnReceiveMessage(str_newmessage, tc, this);
            SocketError se = new SocketError();
            try
            {
                tc.Client.BeginReceive(this.MessageIndex, 0, 4, SocketFlags.None, out se, this.SizeReceiveCallBack, tc);
            }
            catch (Exception AnyError)
            {

                OnReceiveError(new JObject(), _ConCli, this);
            }

        }

        public event RecevieErrorDo OnReceiveError;
        public delegate void RecevieErrorDo(JObject newmessage, TcpClient tc, SocketMessage skm);

        public event ReceiveMessageDo OnReceiveMessage;
        public delegate void ReceiveMessageDo(JObject newmessage, TcpClient tc, SocketMessage skm);

        public void SendContent(JObject Content)
        {
            byte[] Datas = Encoding.UTF8.GetBytes(Content.ToString());
            try
            {
                _ConCli.Client.Send(BitConverter.GetBytes(Datas.Length), 0, 4, SocketFlags.None);
                _ConCli.Client.Send(Datas, 0, Datas.Length, SocketFlags.None);
            }
            catch (Exception)
            {
                OnSendError(new JObject(), _ConCli, this);

            }

        }
        public event SendErrorDo OnSendError;
        public delegate void SendErrorDo(JObject newmessage, TcpClient tc, SocketMessage skm);




    }
}
