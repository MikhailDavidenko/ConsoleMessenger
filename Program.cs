using System;

namespace ConsoleMessenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Console Messenger============");
            Message msg = new Message();
            Console.WriteLine(msg.ToString());
            Console.ReadKey();
        }
    }
}
