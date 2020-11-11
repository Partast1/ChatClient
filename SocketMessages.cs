using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class SocketMessages
    {
        public void ConnectionMadeMsg()
        {
            Console.WriteLine("Connection made");
        }
        public void ReceiveChat(string reveicedMessage)
        {
            Console.WriteLine(reveicedMessage);

        }
    }
}
