using System;
using System.Windows.Forms;
using UDPChat.View;

namespace UDPChat.Presentor
{
    class PresentorUserLogin
    {
        UserLogin userlogin;
        ModelChat modelchat;
        public PresentorUserLogin(UserLogin view,ModelChat model)
        {
            userlogin = view;
            modelchat = model;
            userlogin.LoginBtnClick += LoginBtnClickHandler;
        }
        void LoginBtnClickHandler(object sender,EventArgs e)
        {
            try
            {
                modelchat.UserLogIn(userlogin.LoginTB.Text);
                userlogin.Hide();
                ChatClient chatClient = new ChatClient();
                _ = new PresentorChatClient(chatClient, modelchat);
                chatClient.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
