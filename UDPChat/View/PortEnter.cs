using System;
using System.Windows.Forms;

namespace UDPChat.View
{
    public partial class PortEnter : Form
    {
        public PortEnter()
        {
            InitializeComponent();
        }
        private void LocalPortTB_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < LocalPortTB.Text.Length; i++)
            {
                if (char.IsLetter(LocalPortTB.Text[i]))
                {
                    LocalPortTB.Text = LocalPortTB.Text.Remove(i, 1);
                }
            }
        }
        private void RemotePortTB_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < RemotePortTB.Text.Length; i++)
            {
                if (char.IsLetter(RemotePortTB.Text[i]))
                {
                    RemotePortTB.Text = RemotePortTB.Text.Remove(i, 1);
                }
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var modelchat = new ModelChat();
                modelchat.Remoteport = Convert.ToInt32(RemotePortTB.Text);
                modelchat.Localport = Convert.ToInt32(LocalPortTB.Text);
                this.Hide();
                UserLogin userlogin = new UserLogin();
                _ = new UDPChat.Presentor.PresentorUserLogin(userlogin, modelchat);
                userlogin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void RemotePortTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13) EnterBtn_Click(sender,e);
        }
    }
}
