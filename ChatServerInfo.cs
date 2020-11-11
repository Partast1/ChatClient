using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class ChatServerInfo
    {
        private string serverIp = "172.16.2.30";
        private int port = 50002;

        public string GetServerIp()
        {
            return serverIp;
        }
        public int GetTCPPort()
        {
            return port;
        }

    }
}
