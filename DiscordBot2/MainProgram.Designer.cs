using System.Windows.Forms;

namespace DiscordBot2
{
    partial class DiscordBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordBot));
            this.Title = new System.Windows.Forms.Label();
            this.connectbutton = new System.Windows.Forms.Button();
            this.dcbutton = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.servercount = new System.Windows.Forms.Label();
            this.userscount = new System.Windows.Forms.Label();
            this.channelcount = new System.Windows.Forms.Label();
            this.tokenlabel = new System.Windows.Forms.Label();
            this.tokenbox = new System.Windows.Forms.TextBox();
            this.remembercheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pwencryptlabel = new System.Windows.Forms.Label();
            this.pwencrypt = new System.Windows.Forms.TextBox();
            this.pwdecrypt = new System.Windows.Forms.TextBox();
            this.pwdecryptlabel = new System.Windows.Forms.Label();
            this.encryptbtn = new System.Windows.Forms.Button();
            this.decryptbtn = new System.Windows.Forms.Button();
            this.texttoencrypt = new System.Windows.Forms.TextBox();
            this.texttodecrypt = new System.Windows.Forms.TextBox();
            this.listingbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.botsettingsbutton = new System.Windows.Forms.Button();
            this.versionnumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(380, 45);
            this.Title.TabIndex = 2;
            this.Title.Text = "Rithari\'s Discord Bot";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // connectbutton
            // 
            this.connectbutton.BackColor = System.Drawing.Color.Transparent;
            this.connectbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectbutton.Location = new System.Drawing.Point(10, 111);
            this.connectbutton.Margin = new System.Windows.Forms.Padding(4);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(113, 33);
            this.connectbutton.TabIndex = 4;
            this.connectbutton.TabStop = false;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = false;
            this.connectbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dcbutton
            // 
            this.dcbutton.BackColor = System.Drawing.Color.Transparent;
            this.dcbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcbutton.Location = new System.Drawing.Point(487, 111);
            this.dcbutton.Margin = new System.Windows.Forms.Padding(4);
            this.dcbutton.Name = "dcbutton";
            this.dcbutton.Size = new System.Drawing.Size(132, 33);
            this.dcbutton.TabIndex = 5;
            this.dcbutton.Text = "Disconnect";
            this.dcbutton.UseVisualStyleBackColor = false;
            this.dcbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ControlText;
            this.console.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.SystemColors.Desktop;
            this.console.Location = new System.Drawing.Point(10, 147);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(609, 358);
            this.console.TabIndex = 6;
            this.console.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // servercount
            // 
            this.servercount.AutoSize = true;
            this.servercount.BackColor = System.Drawing.Color.Transparent;
            this.servercount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servercount.ForeColor = System.Drawing.Color.OrangeRed;
            this.servercount.Location = new System.Drawing.Point(130, 93);
            this.servercount.Name = "servercount";
            this.servercount.Size = new System.Drawing.Size(128, 17);
            this.servercount.TabIndex = 7;
            this.servercount.Text = "Servers: OFFLINE";
            // 
            // userscount
            // 
            this.userscount.AutoSize = true;
            this.userscount.BackColor = System.Drawing.Color.Transparent;
            this.userscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userscount.ForeColor = System.Drawing.Color.OrangeRed;
            this.userscount.Location = new System.Drawing.Point(130, 127);
            this.userscount.Name = "userscount";
            this.userscount.Size = new System.Drawing.Size(116, 17);
            this.userscount.TabIndex = 8;
            this.userscount.Text = "Users: OFFLINE";
            // 
            // channelcount
            // 
            this.channelcount.AutoSize = true;
            this.channelcount.BackColor = System.Drawing.Color.Transparent;
            this.channelcount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelcount.ForeColor = System.Drawing.Color.OrangeRed;
            this.channelcount.Location = new System.Drawing.Point(130, 110);
            this.channelcount.Name = "channelcount";
            this.channelcount.Size = new System.Drawing.Size(139, 17);
            this.channelcount.TabIndex = 9;
            this.channelcount.Text = "Channels: OFFLINE";
            // 
            // tokenlabel
            // 
            this.tokenlabel.AutoSize = true;
            this.tokenlabel.BackColor = System.Drawing.Color.Transparent;
            this.tokenlabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenlabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tokenlabel.Location = new System.Drawing.Point(2, 54);
            this.tokenlabel.Name = "tokenlabel";
            this.tokenlabel.Size = new System.Drawing.Size(68, 18);
            this.tokenlabel.TabIndex = 11;
            this.tokenlabel.Text = "Token:";
            // 
            // tokenbox
            // 
            this.tokenbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tokenbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenbox.Location = new System.Drawing.Point(66, 53);
            this.tokenbox.Name = "tokenbox";
            this.tokenbox.PasswordChar = '*';
            this.tokenbox.Size = new System.Drawing.Size(446, 22);
            this.tokenbox.TabIndex = 12;
            // 
            // remembercheckbox
            // 
            this.remembercheckbox.AutoSize = true;
            this.remembercheckbox.BackColor = System.Drawing.Color.Transparent;
            this.remembercheckbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remembercheckbox.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.remembercheckbox.Location = new System.Drawing.Point(517, 55);
            this.remembercheckbox.Name = "remembercheckbox";
            this.remembercheckbox.Size = new System.Drawing.Size(125, 19);
            this.remembercheckbox.TabIndex = 13;
            this.remembercheckbox.Text = "Remember Token";
            this.remembercheckbox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(654, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Text to Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(654, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Text to Decrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(648, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "256bit  Cryptography";
            // 
            // pwencryptlabel
            // 
            this.pwencryptlabel.AutoSize = true;
            this.pwencryptlabel.BackColor = System.Drawing.Color.Transparent;
            this.pwencryptlabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwencryptlabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.pwencryptlabel.Location = new System.Drawing.Point(657, 236);
            this.pwencryptlabel.Name = "pwencryptlabel";
            this.pwencryptlabel.Size = new System.Drawing.Size(65, 16);
            this.pwencryptlabel.TabIndex = 19;
            this.pwencryptlabel.Text = "Password";
            // 
            // pwencrypt
            // 
            this.pwencrypt.BackColor = System.Drawing.SystemColors.Window;
            this.pwencrypt.Location = new System.Drawing.Point(725, 233);
            this.pwencrypt.Name = "pwencrypt";
            this.pwencrypt.PasswordChar = '*';
            this.pwencrypt.Size = new System.Drawing.Size(88, 22);
            this.pwencrypt.TabIndex = 20;
            // 
            // pwdecrypt
            // 
            this.pwdecrypt.Location = new System.Drawing.Point(725, 415);
            this.pwdecrypt.Name = "pwdecrypt";
            this.pwdecrypt.PasswordChar = '*';
            this.pwdecrypt.Size = new System.Drawing.Size(88, 22);
            this.pwdecrypt.TabIndex = 22;
            // 
            // pwdecryptlabel
            // 
            this.pwdecryptlabel.AutoSize = true;
            this.pwdecryptlabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdecryptlabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdecryptlabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.pwdecryptlabel.Location = new System.Drawing.Point(657, 418);
            this.pwdecryptlabel.Name = "pwdecryptlabel";
            this.pwdecryptlabel.Size = new System.Drawing.Size(65, 16);
            this.pwdecryptlabel.TabIndex = 21;
            this.pwdecryptlabel.Text = "Password";
            // 
            // encryptbtn
            // 
            this.encryptbtn.BackColor = System.Drawing.Color.Transparent;
            this.encryptbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptbtn.Location = new System.Drawing.Point(877, 233);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(66, 23);
            this.encryptbtn.TabIndex = 23;
            this.encryptbtn.Text = "Encrypt";
            this.encryptbtn.UseVisualStyleBackColor = false;
            this.encryptbtn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // decryptbtn
            // 
            this.decryptbtn.BackColor = System.Drawing.Color.Transparent;
            this.decryptbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptbtn.Location = new System.Drawing.Point(877, 415);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(66, 23);
            this.decryptbtn.TabIndex = 24;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = false;
            this.decryptbtn.Click += new System.EventHandler(this.decryptbtn_Click);
            // 
            // texttoencrypt
            // 
            this.texttoencrypt.BackColor = System.Drawing.SystemColors.Control;
            this.texttoencrypt.Location = new System.Drawing.Point(652, 110);
            this.texttoencrypt.Multiline = true;
            this.texttoencrypt.Name = "texttoencrypt";
            this.texttoencrypt.Size = new System.Drawing.Size(291, 122);
            this.texttoencrypt.TabIndex = 25;
            // 
            // texttodecrypt
            // 
            this.texttodecrypt.Location = new System.Drawing.Point(657, 291);
            this.texttodecrypt.Multiline = true;
            this.texttodecrypt.Name = "texttodecrypt";
            this.texttodecrypt.Size = new System.Drawing.Size(286, 122);
            this.texttodecrypt.TabIndex = 26;
            // 
            // listingbutton
            // 
            this.listingbutton.BackColor = System.Drawing.Color.Transparent;
            this.listingbutton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listingbutton.Location = new System.Drawing.Point(382, 115);
            this.listingbutton.Name = "listingbutton";
            this.listingbutton.Size = new System.Drawing.Size(98, 26);
            this.listingbutton.TabIndex = 27;
            this.listingbutton.Text = "Server Browser";
            this.listingbutton.UseVisualStyleBackColor = false;
            this.listingbutton.Click += new System.EventHandler(this.listingbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(874, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // botsettingsbutton
            // 
            this.botsettingsbutton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botsettingsbutton.Location = new System.Drawing.Point(862, 475);
            this.botsettingsbutton.Name = "botsettingsbutton";
            this.botsettingsbutton.Size = new System.Drawing.Size(100, 30);
            this.botsettingsbutton.TabIndex = 32;
            this.botsettingsbutton.Text = "Settings";
            this.botsettingsbutton.UseVisualStyleBackColor = true;
            this.botsettingsbutton.Click += new System.EventHandler(this.botsettingsbutton_Click);
            // 
            // versionnumber
            // 
            this.versionnumber.AutoSize = true;
            this.versionnumber.BackColor = System.Drawing.Color.Transparent;
            this.versionnumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionnumber.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.versionnumber.Location = new System.Drawing.Point(390, 30);
            this.versionnumber.Name = "versionnumber";
            this.versionnumber.Size = new System.Drawing.Size(86, 14);
            this.versionnumber.TabIndex = 37;
            this.versionnumber.Text = "Version number";
            // 
            // DiscordBot
            // 
            this.AccessibleDescription = "A Bot made by Rithari";
            this.AccessibleName = "Discord Bot Control Panel";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscordBot2.Properties.Resources._262748;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(974, 517);
            this.Controls.Add(this.versionnumber);
            this.Controls.Add(this.botsettingsbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listingbutton);
            this.Controls.Add(this.texttodecrypt);
            this.Controls.Add(this.texttoencrypt);
            this.Controls.Add(this.decryptbtn);
            this.Controls.Add(this.encryptbtn);
            this.Controls.Add(this.pwdecrypt);
            this.Controls.Add(this.pwdecryptlabel);
            this.Controls.Add(this.pwencrypt);
            this.Controls.Add(this.pwencryptlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remembercheckbox);
            this.Controls.Add(this.tokenbox);
            this.Controls.Add(this.tokenlabel);
            this.Controls.Add(this.channelcount);
            this.Controls.Add(this.userscount);
            this.Controls.Add(this.servercount);
            this.Controls.Add(this.console);
            this.Controls.Add(this.dcbutton);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiscordBot";
            this.Text = "Discord Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label servercount;
        public System.Windows.Forms.Label userscount;
        public System.Windows.Forms.Label channelcount;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Button connectbutton;
        public System.Windows.Forms.Button dcbutton;
        public System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label tokenlabel;
        private System.Windows.Forms.TextBox tokenbox;
        private System.Windows.Forms.CheckBox remembercheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pwencryptlabel;
        private System.Windows.Forms.TextBox pwencrypt;
        private System.Windows.Forms.TextBox pwdecrypt;
        private System.Windows.Forms.Label pwdecryptlabel;
        private System.Windows.Forms.Button encryptbtn;
        private System.Windows.Forms.Button decryptbtn;
        private System.Windows.Forms.TextBox texttoencrypt;
        private System.Windows.Forms.TextBox texttodecrypt;
        private PictureBox pictureBox1;
        public Button listingbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private static PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private Button botsettingsbutton;
        private Label versionnumber;
    }
}

