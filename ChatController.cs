using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class ChatController
    {
        //ICommunication icom;
        public ICommunication icom { get; set; }
        public ChatController(ICommunication ico)
        {
            icom = ico;

        }
        public void Update()
        {

        }
        public void Connect(string ip, int port)
        {
            IConnect icon = (IConnect)icom;
            icon.Connect(ip, port);
        }
        public void SendMessage(Message msg)
        {
            icom.Send(msg);
        }
        public void GetKey()
        {

        }
        public void Receive()
        {
            icom.Receive();
        }
        public void CreateMessage(string msgType)
        {

        }
    }
}
