using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public interface ICommunication
    {
        public void Send(Message message);
        public void Receive();
        public void Listen();
    }
}
