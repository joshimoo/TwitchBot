namespace TwitchViewBot
{
    partial class Form1
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonLoadAccounts = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxChannelToFollow = new System.Windows.Forms.TextBox();
            this.LsbProxies = new System.Windows.Forms.ListBox();
            this.LsbFollowAccounts = new System.Windows.Forms.ListBox();
            this.ButtonFollowChannel = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button10 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.LsbChatAccountsOAuth = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.ButtonStartChatBot = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ButtonIncreasePageViews = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonLoadProxies = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBoxViewChannel = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxViewAmount = new System.Windows.Forms.TextBox();
            this.LsbViewProxies = new System.Windows.Forms.ListBox();
            this.LsbURLSWithTokens = new System.Windows.Forms.ListBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.ButtonGenerateViewLinks = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ButtonLoadAccounts);
            this.GroupBox2.Controls.Add(this.Button8);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.TextBoxChannelToFollow);
            this.GroupBox2.Controls.Add(this.LsbProxies);
            this.GroupBox2.Controls.Add(this.LsbFollowAccounts);
            this.GroupBox2.Controls.Add(this.ButtonFollowChannel);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(681, 198);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "FollowChannel";
            // 
            // ButtonLoadAccounts
            // 
            this.ButtonLoadAccounts.Location = new System.Drawing.Point(342, 159);
            this.ButtonLoadAccounts.Name = "ButtonLoadAccounts";
            this.ButtonLoadAccounts.Size = new System.Drawing.Size(95, 23);
            this.ButtonLoadAccounts.TabIndex = 21;
            this.ButtonLoadAccounts.Text = "Load Accounts";
            this.ButtonLoadAccounts.UseVisualStyleBackColor = true;
            this.ButtonLoadAccounts.Click += new System.EventHandler(this.ButtonLoadAccounts_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(571, 159);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(95, 23);
            this.Button8.TabIndex = 20;
            this.Button8.Text = "Load Proxies";
            this.Button8.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Channel Name:";
            // 
            // TextBoxChannelToFollow
            // 
            this.TextBoxChannelToFollow.Location = new System.Drawing.Point(92, 16);
            this.TextBoxChannelToFollow.Name = "TextBoxChannelToFollow";
            this.TextBoxChannelToFollow.Size = new System.Drawing.Size(100, 20);
            this.TextBoxChannelToFollow.TabIndex = 3;
            // 
            // LsbProxies
            // 
            this.LsbProxies.FormattingEnabled = true;
            this.LsbProxies.Location = new System.Drawing.Point(443, 19);
            this.LsbProxies.Name = "LsbProxies";
            this.LsbProxies.Size = new System.Drawing.Size(223, 134);
            this.LsbProxies.TabIndex = 2;
            // 
            // LsbFollowAccounts
            // 
            this.LsbFollowAccounts.FormattingEnabled = true;
            this.LsbFollowAccounts.Location = new System.Drawing.Point(214, 19);
            this.LsbFollowAccounts.Name = "LsbFollowAccounts";
            this.LsbFollowAccounts.Size = new System.Drawing.Size(223, 134);
            this.LsbFollowAccounts.TabIndex = 1;
            // 
            // ButtonFollowChannel
            // 
            this.ButtonFollowChannel.Location = new System.Drawing.Point(9, 42);
            this.ButtonFollowChannel.Name = "ButtonFollowChannel";
            this.ButtonFollowChannel.Size = new System.Drawing.Size(183, 23);
            this.ButtonFollowChannel.TabIndex = 0;
            this.ButtonFollowChannel.Text = "Start!";
            this.ButtonFollowChannel.UseVisualStyleBackColor = true;
            this.ButtonFollowChannel.Click += new System.EventHandler(this.ButtonFollowChannel_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button10);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.TextBox4);
            this.GroupBox3.Controls.Add(this.LsbChatAccountsOAuth);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.TextBox3);
            this.GroupBox3.Controls.Add(this.ButtonStartChatBot);
            this.GroupBox3.Location = new System.Drawing.Point(722, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(399, 198);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "ChatBot";
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(296, 172);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(95, 23);
            this.Button10.TabIndex = 22;
            this.Button10.Text = "Load Accounts";
            this.Button10.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 50);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Message:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(9, 66);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(223, 71);
            this.TextBox4.TabIndex = 9;
            // 
            // LsbChatAccountsOAuth
            // 
            this.LsbChatAccountsOAuth.FormattingEnabled = true;
            this.LsbChatAccountsOAuth.Location = new System.Drawing.Point(238, 19);
            this.LsbChatAccountsOAuth.Name = "LsbChatAccountsOAuth";
            this.LsbChatAccountsOAuth.Size = new System.Drawing.Size(153, 147);
            this.LsbChatAccountsOAuth.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Channel Name:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(92, 21);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 6;
            // 
            // ButtonStartChatBot
            // 
            this.ButtonStartChatBot.Location = new System.Drawing.Point(9, 143);
            this.ButtonStartChatBot.Name = "ButtonStartChatBot";
            this.ButtonStartChatBot.Size = new System.Drawing.Size(223, 23);
            this.ButtonStartChatBot.TabIndex = 5;
            this.ButtonStartChatBot.Text = "Start!";
            this.ButtonStartChatBot.UseVisualStyleBackColor = true;
            this.ButtonStartChatBot.Click += new System.EventHandler(this.ButtonStartChatBot_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.ButtonIncreasePageViews);
            this.GroupBox1.Location = new System.Drawing.Point(722, 216);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(203, 97);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Increase Page Views";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Channel Name:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(92, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // ButtonIncreasePageViews
            // 
            this.ButtonIncreasePageViews.Location = new System.Drawing.Point(9, 50);
            this.ButtonIncreasePageViews.Name = "ButtonIncreasePageViews";
            this.ButtonIncreasePageViews.Size = new System.Drawing.Size(183, 23);
            this.ButtonIncreasePageViews.TabIndex = 0;
            this.ButtonIncreasePageViews.Text = "Start!";
            this.ButtonIncreasePageViews.UseVisualStyleBackColor = true;
            this.ButtonIncreasePageViews.Click += new System.EventHandler(this.ButtonIncreasePageViews_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.ButtonLoadProxies);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.TextBoxViewChannel);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.TextBoxViewAmount);
            this.GroupBox4.Controls.Add(this.LsbViewProxies);
            this.GroupBox4.Controls.Add(this.LsbURLSWithTokens);
            this.GroupBox4.Controls.Add(this.Button4);
            this.GroupBox4.Controls.Add(this.Button5);
            this.GroupBox4.Controls.Add(this.ButtonGenerateViewLinks);
            this.GroupBox4.Location = new System.Drawing.Point(12, 216);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(576, 187);
            this.GroupBox4.TabIndex = 5;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Increase LIVE viewers";
            // 
            // ButtonLoadProxies
            // 
            this.ButtonLoadProxies.Location = new System.Drawing.Point(475, 158);
            this.ButtonLoadProxies.Name = "ButtonLoadProxies";
            this.ButtonLoadProxies.Size = new System.Drawing.Size(95, 23);
            this.ButtonLoadProxies.TabIndex = 19;
            this.ButtonLoadProxies.Text = "Load Proxies";
            this.ButtonLoadProxies.UseVisualStyleBackColor = true;
            this.ButtonLoadProxies.Click += new System.EventHandler(this.ButtonLoadProxies_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 13);
            this.Label6.TabIndex = 18;
            this.Label6.Text = "Channel Name:";
            // 
            // TextBoxViewChannel
            // 
            this.TextBoxViewChannel.Location = new System.Drawing.Point(92, 16);
            this.TextBoxViewChannel.Name = "TextBoxViewChannel";
            this.TextBoxViewChannel.Size = new System.Drawing.Size(76, 20);
            this.TextBoxViewChannel.TabIndex = 17;
            this.TextBoxViewChannel.Text = "Devchan";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 45);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "ViewAmount:";
            // 
            // TextBoxViewAmount
            // 
            this.TextBoxViewAmount.Location = new System.Drawing.Point(92, 42);
            this.TextBoxViewAmount.Name = "TextBoxViewAmount";
            this.TextBoxViewAmount.Size = new System.Drawing.Size(76, 20);
            this.TextBoxViewAmount.TabIndex = 15;
            this.TextBoxViewAmount.Text = "300";
            // 
            // LsbViewProxies
            // 
            this.LsbViewProxies.FormattingEnabled = true;
            this.LsbViewProxies.Location = new System.Drawing.Point(347, 19);
            this.LsbViewProxies.Name = "LsbViewProxies";
            this.LsbViewProxies.Size = new System.Drawing.Size(223, 134);
            this.LsbViewProxies.TabIndex = 14;
            // 
            // LsbURLSWithTokens
            // 
            this.LsbURLSWithTokens.FormattingEnabled = true;
            this.LsbURLSWithTokens.Location = new System.Drawing.Point(221, 19);
            this.LsbURLSWithTokens.Name = "LsbURLSWithTokens";
            this.LsbURLSWithTokens.Size = new System.Drawing.Size(120, 134);
            this.LsbURLSWithTokens.TabIndex = 13;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(9, 134);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(159, 23);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "Stop!";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(9, 105);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(159, 23);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "Start!";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerateViewLinks
            // 
            this.ButtonGenerateViewLinks.Location = new System.Drawing.Point(9, 76);
            this.ButtonGenerateViewLinks.Name = "ButtonGenerateViewLinks";
            this.ButtonGenerateViewLinks.Size = new System.Drawing.Size(159, 23);
            this.ButtonGenerateViewLinks.TabIndex = 10;
            this.ButtonGenerateViewLinks.Text = "Generate Links";
            this.ButtonGenerateViewLinks.UseVisualStyleBackColor = true;
            this.ButtonGenerateViewLinks.Click += new System.EventHandler(this.ButtonGenerateViewLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 427);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button ButtonLoadAccounts;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxChannelToFollow;
        internal System.Windows.Forms.ListBox LsbProxies;
        internal System.Windows.Forms.ListBox LsbFollowAccounts;
        internal System.Windows.Forms.Button ButtonFollowChannel;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.ListBox LsbChatAccountsOAuth;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Button ButtonStartChatBot;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button ButtonIncreasePageViews;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button ButtonLoadProxies;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBoxViewChannel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxViewAmount;
        internal System.Windows.Forms.ListBox LsbViewProxies;
        internal System.Windows.Forms.ListBox LsbURLSWithTokens;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button ButtonGenerateViewLinks;
    }
}

