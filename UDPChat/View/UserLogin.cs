using System;
using System.Windows.Forms;

namespace UDPChat.View
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        public EventHandler LoginBtnClick;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginBtnClick.Invoke(sender, e);
        }

        private void LoginTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13) LoginBtn_Click(sender, e);
        }
    }
}
