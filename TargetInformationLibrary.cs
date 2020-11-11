using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public class TargetInformationLibrary
    {
        public TargetInformation GetInfo(string name, string ip)
        {
            TargetInformation targetInfo = new TargetInformation(name, ip);
            return targetInfo;
        }
    }
}
