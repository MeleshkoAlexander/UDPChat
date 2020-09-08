using System;
using System.Threading.Tasks;
using UDPChat.View;

namespace UDPChat.Presentor
{
    class PresentorChatClient
    {
        ChatClient chatClient;
        ModelChat modelChat;
        public PresentorChatClient(ChatClient view, ModelChat model)
        {
            chatClient = view;
            modelChat = model;
            ReceiveMessagesAsync();
            modelChat.SendMessage(" вошел в чат");
            chatClient.ChatClientClosed += ChatClientClosedHandler;
            chatClient.SendBtnClick += SendBtnClickHandler;
        }
        void ChatClientClosedHandler(object sender, EventArgs e)
        {
            modelChat.Disconnect();
        }
        private async void ReceiveMessagesAsync()
        {
            while (true)
            {
                chatClient.ChatRTB.AppendText(await Task.Run(() => modelChat.ReceiveMessage()));
            }
        }
        void SendBtnClickHandler(object sender, EventArgs e)
        {
            modelChat.SendMessage(": " + chatClient.MessageTB.Text);
            chatClient.MessageTB.Text = string.Empty;
        }
    }
}
