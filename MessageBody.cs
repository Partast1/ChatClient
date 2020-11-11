using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class MessageBody
    {
        private string body;
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        public MessageBody(string body)
        {
            Body = body;
        }
        public MessageBody()
        {

        }

    }
}
