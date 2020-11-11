using System;
using System.Threading;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatController chatController = new ChatController(new SocketHandler());
            TargetInformationLibrary tInformation = new TargetInformationLibrary();
            ChatServerInfo serverInfo = new ChatServerInfo();
            string myIp = "172.16.2.47";
            string myName = "Anders";
            string messageInput;
            bool targetIpCheck = false;
            string receiveIpInput = "";
            string receiveName = "";
            //1 Connect to chat server, 2 Select person/ip to chat with, 3 type message
            while (true)
            {
                //chatController.Receive();
                Console.WriteLine("Press 1 to Connect to server | Press 2 to select Ip | Press 3 to type message");

                int navigatorInt = Int32.Parse(Console.ReadLine());
                switch (navigatorInt)
                {
                    case 1:
                        //Forbinder til chatserveren
                        chatController.Connect(serverInfo.GetServerIp(), serverInfo.GetTCPPort());

                        Thread receiveThread = new Thread(new ThreadStart(chatController.Receive));
                        receiveThread.Start();
                        break;
                    case 2:
                        //Brugeren skriver ip og navn på den de vil chatte med.
                        Console.WriteLine("Target ip");
                        receiveIpInput = Console.ReadLine();
                        targetIpCheck = true;
                        Console.WriteLine("Receivers name");
                        receiveName = Console.ReadLine();
                        break;
                    case 3:
                        //Checker om der er valgt en target ip og der laves bagefter en ny besked.
                        if (targetIpCheck == true)
                        {
                            Console.WriteLine("Type message");
                            messageInput = Console.ReadLine();

                            //Message message = new Message(tInformation.GetInfo(myName, myIp ), tInformation.GetInfo(receiveName, receiveIpInput), new MessageBody(messageInput));
                            SocketMessage sMessage = new SocketMessage("Ders", "Anders", myIp,receiveName, receiveIpInput, messageInput);
                            chatController.SendMessage(sMessage);
                        }
                        //if (targetIpCheck == true)
                        //{
                        //    Console.WriteLine("Type message");
                        //    messageInput = Console.ReadLine();

                        //    Message message = new Message(tInformation.GetInfo(myName, myIp), tInformation.GetInfo(receiveName, receiveIpInput), new MessageBody(messageInput));
                        //    chatController.SendMessage(message);
                        //}
                        break;
                }
            }
            
            
        }
    }
}
 