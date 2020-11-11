using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class TargetInformation
    {
        public string Name { get; set; }
        public string Ip { get; set; }

        public TargetInformation(string name, string ip)
        {
            Name = name;
            Ip = ip;
        }
      
        public TargetInformation()
        {

        }

    }
}
