namespace DiscordBot2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Maintext = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.changeavatar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changename = new System.Windows.Forms.Button();
            this.botnametextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directorytextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botgamenametextbox = new System.Windows.Forms.TextBox();
            this.changegame = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Maintext
            // 
            this.Maintext.AutoSize = true;
            this.Maintext.BackColor = System.Drawing.Color.Transparent;
            this.Maintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintext.Location = new System.Drawing.Point(194, 9);
            this.Maintext.Name = "Maintext";
            this.Maintext.Size = new System.Drawing.Size(325, 39);
            this.Maintext.TabIndex = 0;
            this.Maintext.Text = "Discord Bot Settings";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // changeavatar
            // 
            this.changeavatar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeavatar.Location = new System.Drawing.Point(17, 101);
            this.changeavatar.Name = "changeavatar";
            this.changeavatar.Size = new System.Drawing.Size(142, 23);
            this.changeavatar.TabIndex = 33;
            this.changeavatar.Text = "Change Bot Avatar";
            this.changeavatar.UseVisualStyleBackColor = true;
            this.changeavatar.Click += new System.EventHandler(this.changeavatar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select an image to upload as your bot avatar from your computer.";
            // 
            // changename
            // 
            this.changename.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changename.Location = new System.Drawing.Point(17, 196);
            this.changename.Name = "changename";
            this.changename.Size = new System.Drawing.Size(142, 23);
            this.changename.TabIndex = 35;
            this.changename.Text = "Change Bot Name";
            this.changename.UseVisualStyleBackColor = true;
            this.changename.Click += new System.EventHandler(this.changename_Click);
            // 
            // botnametextbox
            // 
            this.botnametextbox.Location = new System.Drawing.Point(175, 199);
            this.botnametextbox.Name = "botnametextbox";
            this.botnametextbox.Size = new System.Drawing.Size(268, 20);
            this.botnametextbox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter a new name for your bot in the textbox and press the change bot name button" +
    " to confirm.";
            // 
            // directorytextbox
            // 
            this.directorytextbox.BackColor = System.Drawing.SystemColors.Control;
            this.directorytextbox.Location = new System.Drawing.Point(175, 102);
            this.directorytextbox.Name = "directorytextbox";
            this.directorytextbox.ReadOnly = true;
            this.directorytextbox.Size = new System.Drawing.Size(268, 20);
            this.directorytextbox.TabIndex = 38;
            this.directorytextbox.TextChanged += new System.EventHandler(this.directorytextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Profile Picture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 73);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(256, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(172, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Recommended size: 128 x128";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Browse Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Game";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Enter a game to be displayed as the bot\'s current game. Will stop the constant ga" +
    "me changing.";
            // 
            // botgamenametextbox
            // 
            this.botgamenametextbox.Location = new System.Drawing.Point(175, 297);
            this.botgamenametextbox.Name = "botgamenametextbox";
            this.botgamenametextbox.Size = new System.Drawing.Size(268, 20);
            this.botgamenametextbox.TabIndex = 45;
            // 
            // changegame
            // 
            this.changegame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changegame.Location = new System.Drawing.Point(17, 294);
            this.changegame.Name = "changegame";
            this.changegame.Size = new System.Drawing.Size(142, 23);
            this.changegame.TabIndex = 44;
            this.changegame.Text = "Change Current Game";
            this.changegame.UseVisualStyleBackColor = true;
            this.changegame.Click += new System.EventHandler(this.changegame_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(421, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "If your image is not 128 x 128 it will not be displayed correctly in Discord.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(172, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Maximum Size: 256x256";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(172, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(337, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Bellend names will most likely get you suspended from several servers.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(172, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(366, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Bellend game names will most likely get you suspended from several servers.";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Re-enable constant game changing.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botgamenametextbox);
            this.Controls.Add(this.changegame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directorytextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botnametextbox);
            this.Controls.Add(this.changename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeavatar);
            this.Controls.Add(this.Maintext);
            this.DoubleBuffered = true;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Maintext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button changeavatar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button changename;
        public System.Windows.Forms.TextBox botnametextbox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox directorytextbox;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox botgamenametextbox;
        public System.Windows.Forms.Button changegame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button button2;
    }
}