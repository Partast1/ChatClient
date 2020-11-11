using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class MessageFactory
    {
        public PlainMessage CreateMessage(TargetInformation from, TargetInformation to, MessageBody msg)
        {
            PlainMessage message = new PlainMessage(from, to, msg);
            return message;
        }
    }
}
