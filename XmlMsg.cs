using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ChatClient
{
    public class XmlMsg 
    {
        XmlSerializer serializer;
        public byte[] ConvertToXML(Message msg)
        {
            serializer = new XmlSerializer(msg.GetType(), new XmlRootAttribute("SocketMessage"));
            //SocketMessage
            byte[] bufferStream = new byte[1024];
            MemoryStream s = new MemoryStream(bufferStream);
            serializer.Serialize(s, msg);

            return Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(bufferStream).Replace("\0", ""));
        }
        public void DeserializerXML()
        {
            //serializer.Deserialize
        }
    }
}
