using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int MessageId = 0;
        private static string UserName;
        private static MessengerClientCons Api = new MessengerClientCons();
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {
                List<Message> msg = await Api.GetMessageHttpAsync(MessageId);
                if (msg != null)
                {
                    for (int i = 0; i < msg.Count; i++)
                    {
                        MessagesLB.Items.Add(msg[i]);
                        MessageId++;
                    }
                }
            });
            getMessage.Invoke();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            string UserN = UserField.Text;
            string MessageT = MessageField.Text;
            if (UserN.Length > 0 && MessageT.Length > 0)
            {
                Message msg = new Message(UserN, MessageT, DateTime.Now);
                Api.PostMessage(msg);
            }
        }
    }
}
