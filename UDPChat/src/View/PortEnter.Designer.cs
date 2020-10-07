namespace UDPChat.View
{
    partial class PortEnter
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
            this.LPortLbl = new System.Windows.Forms.Label();
            this.RPortLbl = new System.Windows.Forms.Label();
            this.LocalPortTB = new System.Windows.Forms.TextBox();
            this.RemotePortTB = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LPortLbl
            // 
            this.LPortLbl.AutoSize = true;
            this.LPortLbl.Location = new System.Drawing.Point(12, 56);
            this.LPortLbl.Name = "LPortLbl";
            this.LPortLbl.Size = new System.Drawing.Size(67, 17);
            this.LPortLbl.TabIndex = 0;
            this.LPortLbl.Text = "Localport";
            // 
            // RPortLbl
            // 
            this.RPortLbl.AutoSize = true;
            this.RPortLbl.Location = new System.Drawing.Point(12, 85);
            this.RPortLbl.Name = "RPortLbl";
            this.RPortLbl.Size = new System.Drawing.Size(82, 17);
            this.RPortLbl.TabIndex = 1;
            this.RPortLbl.Text = "Remoteport";
            // 
            // LocalPortTB
            // 
            this.LocalPortTB.Location = new System.Drawing.Point(100, 56);
            this.LocalPortTB.Name = "LocalPortTB";
            this.LocalPortTB.Size = new System.Drawing.Size(105, 22);
            this.LocalPortTB.TabIndex = 2;
            this.LocalPortTB.TextChanged += new System.EventHandler(this.LocalPortTB_TextChanged);
            // 
            // RemotePortTB
            // 
            this.RemotePortTB.Location = new System.Drawing.Point(100, 85);
            this.RemotePortTB.Name = "RemotePortTB";
            this.RemotePortTB.Size = new System.Drawing.Size(105, 22);
            this.RemotePortTB.TabIndex = 3;
            this.RemotePortTB.TextChanged += new System.EventHandler(this.RemotePortTB_TextChanged);
            this.RemotePortTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemotePortTB_KeyPress);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(130, 123);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 29);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // PortEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 176);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.RemotePortTB);
            this.Controls.Add(this.LocalPortTB);
            this.Controls.Add(this.RPortLbl);
            this.Controls.Add(this.LPortLbl);
            this.Name = "PortEnter";
            this.Text = "PortEnter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPortLbl;
        private System.Windows.Forms.Label RPortLbl;
        private System.Windows.Forms.TextBox LocalPortTB;
        private System.Windows.Forms.TextBox RemotePortTB;
        private System.Windows.Forms.Button EnterBtn;
    }
}