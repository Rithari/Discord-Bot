using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        Stream selectedFile { get; set; }
        public void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog1.OpenFile();
                string fullPath = openFileDialog1.FileName;
                string directory = fullPath.Substring(0, fullPath.LastIndexOf('\\'));
                directorytextbox.Text = directory;
                pictureBox1.Image = Image.FromStream(selectedFile);


            }
    }

        public async void changeavatar_Click(object sender, EventArgs e)
        {
            if (directorytextbox.Text == null)
            {
                MessageBox.Show("Error", "You must specify a string to set.");
                return;
            }
            await DiscordBot.Client.CurrentUser.Edit(avatar: selectedFile);
        }

        private async void changename_Click(object sender, EventArgs e)
        {
            if (botnametextbox.Text == null)
            {
                MessageBox.Show("Error", "You must specify a string to set.");
                return;
            }
            await DiscordBot.Client.CurrentUser.Edit(username: botnametextbox.Text);
        }

        private void changegame_Click(object sender, EventArgs e)
        {
            if (botgamenametextbox.Text == null)
            {
                MessageBox.Show("Error", "You must specify a string to set.");
                return;
            }
             DiscordBot.Client.SetGame(botgamenametextbox.Text);
            DiscordBot.Gamechanging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DiscordBot.Gamechanging)
            {
                MessageBox.Show("Error", "This loop is already active!");
                return;
            }
            DiscordBot.Gamechanging = true;
        }

        private void directorytextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
