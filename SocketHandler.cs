using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClient
{
    public class SocketHandler : IConnect, ICommunication
    {
        //private static ManualResetEvent connectDone = new ManualResetEvent(false);
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketMessages sockMessages = new SocketMessages();

        public void Connect(string ip, int port)
        {
            try
            {

                while (!socket.Connected)
                {
                    try
                    {
                        socket.Connect(ip, port);
                        sockMessages.ConnectionMadeMsg();
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    //finally
                    //{
                    //    socket.Disconnect(true);
                    //}
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Listen()
        {

        }

        public void Receive()
        {
            if (socket.Connected)
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int iRx = socket.Receive(buffer);
                    char[] chars = new char[iRx];

                    Decoder d = Encoding.UTF8.GetDecoder();
                    int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
                    string recv = new string(chars);
                    sockMessages.ReceiveChat(recv);
                }
            }
            else
            {
            }
        }

        public void Send(Message message)
        {
            byte[] messageInBytes = new byte[1024];
            XmlMsg xmlMsg = new XmlMsg();
            if (message is SocketMessage)
            {
                var xmlCaster = (SocketMessage)message;
                messageInBytes = xmlMsg.ConvertToXML(message);


            }
            else if (message is PlainMessage)
            {
                var plainCaster = (PlainMessage)message;
                messageInBytes = Encoding.UTF8.GetBytes(plainCaster.ToString());
            }
            try
            {
                if (socket.Connected)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("it's a connected");
                    socket.Send(messageInBytes);



                    //if (socket.Available >= 1)
                    //{
                    //}
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
