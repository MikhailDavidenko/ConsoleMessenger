using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerServer.Models
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }
        public Message()
        {
            UserName = "System";
            MessageText = "Messenger is running...";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format($"{TimeStamp}\nUser: {UserName}\n   {MessageText}");
        }

    }
}
