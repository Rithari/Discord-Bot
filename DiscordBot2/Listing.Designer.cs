namespace DiscordBot2
{
    partial class Listing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Servers = new System.Windows.Forms.ListBox();
            this.Channels = new System.Windows.Forms.ListBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendtochannel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendtouser = new System.Windows.Forms.Button();
            this.createinvite = new System.Windows.Forms.Button();
            this.ownerbutton = new System.Windows.Forms.Button();
            this.leaveserver = new System.Windows.Forms.Button();
            this.kickbutton = new System.Windows.Forms.Button();
            this.banuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(260, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(516, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Channels";
            // 
            // Servers
            // 
            this.Servers.FormattingEnabled = true;
            this.Servers.Location = new System.Drawing.Point(309, 13);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(201, 550);
            this.Servers.TabIndex = 2;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // Channels
            // 
            this.Channels.FormattingEnabled = true;
            this.Channels.Location = new System.Drawing.Point(573, 12);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(201, 550);
            this.Channels.TabIndex = 3;
            this.Channels.SelectedIndexChanged += new System.EventHandler(this.Channels_SelectedIndexChanged);
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(837, 12);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(201, 550);
            this.Users.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(780, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(298, 37);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // sendtochannel
            // 
            this.sendtochannel.Location = new System.Drawing.Point(162, 118);
            this.sendtochannel.Name = "sendtochannel";
            this.sendtochannel.Size = new System.Drawing.Size(141, 23);
            this.sendtochannel.TabIndex = 8;
            this.sendtochannel.Text = "Send message to channel.";
            this.sendtochannel.UseVisualStyleBackColor = true;
            this.sendtochannel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-266, -44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sendtouser
            // 
            this.sendtouser.Location = new System.Drawing.Point(5, 118);
            this.sendtouser.Name = "sendtouser";
            this.sendtouser.Size = new System.Drawing.Size(141, 23);
            this.sendtouser.TabIndex = 11;
            this.sendtouser.Text = "Send message to user";
            this.sendtouser.UseVisualStyleBackColor = true;
            this.sendtouser.Click += new System.EventHandler(this.sendtouser_Click);
            // 
            // createinvite
            // 
            this.createinvite.Location = new System.Drawing.Point(162, 147);
            this.createinvite.Name = "createinvite";
            this.createinvite.Size = new System.Drawing.Size(141, 23);
            this.createinvite.TabIndex = 33;
            this.createinvite.Text = "Create channel invite";
            this.createinvite.UseVisualStyleBackColor = true;
            this.createinvite.Click += new System.EventHandler(this.createinvite_Click);
            // 
            // ownerbutton
            // 
            this.ownerbutton.Location = new System.Drawing.Point(5, 147);
            this.ownerbutton.Name = "ownerbutton";
            this.ownerbutton.Size = new System.Drawing.Size(141, 23);
            this.ownerbutton.TabIndex = 34;
            this.ownerbutton.Text = "Server Information";
            this.ownerbutton.UseVisualStyleBackColor = true;
            this.ownerbutton.Click += new System.EventHandler(this.ownerbutton_Click);
            // 
            // leaveserver
            // 
            this.leaveserver.Location = new System.Drawing.Point(74, 205);
            this.leaveserver.Name = "leaveserver";
            this.leaveserver.Size = new System.Drawing.Size(141, 23);
            this.leaveserver.TabIndex = 35;
            this.leaveserver.Text = "Leave server";
            this.leaveserver.UseVisualStyleBackColor = true;
            this.leaveserver.Click += new System.EventHandler(this.leaveserver_Click);
            // 
            // kickbutton
            // 
            this.kickbutton.Location = new System.Drawing.Point(5, 176);
            this.kickbutton.Name = "kickbutton";
            this.kickbutton.Size = new System.Drawing.Size(141, 23);
            this.kickbutton.TabIndex = 36;
            this.kickbutton.Text = "Kick user";
            this.kickbutton.UseVisualStyleBackColor = true;
            this.kickbutton.Click += new System.EventHandler(this.kickbutton_Click);
            // 
            // banuser
            // 
            this.banuser.Location = new System.Drawing.Point(162, 176);
            this.banuser.Name = "banuser";
            this.banuser.Size = new System.Drawing.Size(141, 23);
            this.banuser.TabIndex = 37;
            this.banuser.Text = "Ban user";
            this.banuser.UseVisualStyleBackColor = true;
            this.banuser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 563);
            this.Controls.Add(this.banuser);
            this.Controls.Add(this.kickbutton);
            this.Controls.Add(this.leaveserver);
            this.Controls.Add(this.ownerbutton);
            this.Controls.Add(this.createinvite);
            this.Controls.Add(this.sendtouser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendtochannel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Channels);
            this.Controls.Add(this.Servers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listing";
            this.Text = "Server Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Listing_FormClosed);
            this.Load += new System.EventHandler(this.Listing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox Servers;
        public System.Windows.Forms.ListBox Channels;
        public System.Windows.Forms.ListBox Users;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button sendtochannel;
        public System.Windows.Forms.Button sendtouser;
        private System.Windows.Forms.Button createinvite;
        private System.Windows.Forms.Button ownerbutton;
        private System.Windows.Forms.Button leaveserver;
        private System.Windows.Forms.Button kickbutton;
        private System.Windows.Forms.Button banuser;
    }
}