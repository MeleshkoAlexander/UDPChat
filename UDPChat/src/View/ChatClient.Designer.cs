namespace UDPChat.View
{
    partial class ChatClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ChatRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(12, 441);
            this.MessageTB.Multiline = true;
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageTB.Size = new System.Drawing.Size(596, 71);
            this.MessageTB.TabIndex = 0;
            this.MessageTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageTB_KeyPress);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(614, 441);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(217, 70);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ChatRTB
            // 
            this.ChatRTB.Location = new System.Drawing.Point(12, 12);
            this.ChatRTB.Name = "ChatRTB";
            this.ChatRTB.ReadOnly = true;
            this.ChatRTB.Size = new System.Drawing.Size(819, 423);
            this.ChatRTB.TabIndex = 4;
            this.ChatRTB.Text = "";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.ChatRTB);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MessageTB);
            this.Name = "ChatClient";
            this.Text = "UDPChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendBtn;
        public System.Windows.Forms.TextBox MessageTB;
        public System.Windows.Forms.RichTextBox ChatRTB;
    }
}

