using System;
using System.Windows.Forms;

namespace UDPChat.View
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            InitializeComponent();
        }

        private void MessageTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = true;
                SendBtn_Click(sender, e);
            }
        }
        public EventHandler ChatClientClosed;
        private void ChatClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChatClientClosed.Invoke(sender, e);
        }
        public EventHandler SendBtnClick;
        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendBtnClick.Invoke(sender, e);
        }
    }
}
