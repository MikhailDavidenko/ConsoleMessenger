using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private static int MessageId = 0;
        private static string UserName;
        private static MessengerClientCons Api = new MessengerClientCons();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {
                Message msg = await Api.GetMessageHttpAsync(MessageId);
                while(msg != null)
                {
                    MessageLB.Items.Add(msg);
                    MessageId++;
                    msg = await Api.GetMessageHttpAsync(MessageId);
                }
            });
            getMessage.Invoke();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string UserN = UserBox.Text;
            string MessageT = MessageBox.Text;
            if(UserN.Length > 0 && MessageT.Length > 0)
            {
                Message msg = new Message(UserN, MessageT, DateTime.Now);
                Api.PostMessage(msg);
            }


         }
    }
}
