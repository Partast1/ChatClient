using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class PlainMessage : Message
    {
        public TargetInformation From { get; set; }
        public TargetInformation To { get; set; }
        public MessageBody Mb { get; set; }
        public PlainMessage(TargetInformation from, TargetInformation to, MessageBody messageBody)
        {
            From = from;
            To = to;
            Mb = messageBody;
        }
        public PlainMessage() 
        {

        }
        
        public string ToString()
        {
            //return "Ders:" + From.Name + ":" + From.Ip + ":" + To.Name + ":" + To.Ip + ":" + Mb.Body + ":{END}";
            return From.Name + ":" + From.Ip + ":" + To.Name + ":" + To.Ip + ":" + Mb.Body + "\r\n";

        }
    }
}
