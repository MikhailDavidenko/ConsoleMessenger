using System;
using Newtonsoft.Json;

namespace ConsoleMessenger
{
    internal class Program
    {
        private static int MessageId;
        private static string UserName;
        private static MessengerClientCons Api = new MessengerClientCons();

        private static void GetNewMessage()
        {
            Message msg = Api.GetMessage(MessageId);
            while(msg != null)
            {
                Console.WriteLine(msg);
                MessageId++;
                msg = Api.GetMessage(MessageId);
            }
        } 
        
        static void Main(string[] args)
        {
            MessageId = 1;
            Console.Write("Введите ваше имя: ");
            UserName = Console.ReadLine();
            string MessageText = "";
            while(MessageText != "x")
            {
                GetNewMessage();
                MessageText = Console.ReadLine();
                if(MessageText.Length >= 1)
                {
                    Message SendMsg = new Message(UserName, MessageText, DateTime.Now);
                    Api.PostMessage(SendMsg);
                }
            }
        }
    }
}
