using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    interface IConnect
    {
        public void Connect(string ip, int port);
    }
}
