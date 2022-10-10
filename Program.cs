using System;
using Newtonsoft.Json;

namespace ConsoleMessenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Console Messenger============");
            Message msg = new Message();
            Console.WriteLine(msg.ToString());
            
            Message testJson = new Message("user", "some text", DateTime.Now);
            string output = JsonConvert.SerializeObject(testJson);
            Console.WriteLine(output);

            msg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
