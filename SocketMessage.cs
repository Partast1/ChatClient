using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class SocketMessage : Message
    {
        private string nickName;
        private string senderHostName;
        private string senderIpAddress;
        private string receiverHostName;
        private string receiverIpAddresse;
        private string chatMessage;

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public string SenderHostName
        {
            get { return senderHostName; }
            set { senderHostName = value; }
        }
        public string SenderIpAddress
        {
            get { return senderIpAddress; }
            set { senderIpAddress = value; }
        }
        public string ReceiverHostName
        {
            get { return receiverHostName; }
            set { receiverHostName = value; }
        }
        public string ReceiverIpAddress
        {
            get { return receiverIpAddresse; }
            set { receiverIpAddresse = value; }
        }
        public string ChatMessage
        {
            get { return chatMessage; }
            set { chatMessage = value; }
        }
        public SocketMessage(string nickName, string senderHostName, string senderIpAddress, string receiverHostName, string receiverIpAddress, string chatMessage)
        {
            NickName = nickName;
            SenderHostName = senderHostName;
            SenderIpAddress = senderIpAddress;
            ReceiverHostName = receiverHostName;
            ReceiverIpAddress = receiverIpAddress;
            ChatMessage = chatMessage + "{END}";

        }
        public SocketMessage()
        {

        }
     
    }
}
