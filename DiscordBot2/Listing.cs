using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;

namespace DiscordBot2
{
    public partial class Listing : Form
    {
        public Listing()
        {
            InitializeComponent();
        }
        private void Listing_Load(object sender, EventArgs e)
        {
            Servers.DataSource = DiscordBot.Client.Servers.Select(x => x.Name).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a server, select a channel, enter a message to send and then press the send button.\n Select a server, select a channel, select a User, enter a message to send and then press the send message to user button.\nSelect a server, select a channel and press the create invite for channel button. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Channel target = DiscordBot.Client.Servers.Single(x => x.Name.Contains(Servers.SelectedItem.ToString())).AllChannels.Single(x => x.Name.Contains(Channels.SelectedItem.ToString()));
                target.SendMessage(richTextBox1.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select a channel to send a message!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Your message can't be empty!"); 
            }
        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Channels.DataSource = Servers.SelectedItem.ToString().ToServer(DiscordBot.Client.Servers).AllChannels.Select(x => x.Name).ToList();
        }

        private void Channels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server t = Servers.SelectedItem.ToString().ToServer(DiscordBot.Client.Servers);
            Users.DataSource = Channels.SelectedItem.ToString().ToChannel(t.AllChannels).Users.Select(x => x.Name).ToList();
        }

        private void sendtouser_Click(object sender, EventArgs e)
        {
            User target2 = DiscordBot.Client.Servers.Single(x => x.Name.Contains(Servers.SelectedItem.ToString())).AllChannels.Single(x => x.Name.Contains(Channels.SelectedItem.ToString())).Users.Single(x => x.Name.Contains(Users.SelectedItem.ToString()));
            target2.SendMessage(richTextBox1.Text);
        }

        private void Listing_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void createinvite_Click(object sender, EventArgs e)
        {
            try
            {
                Channel target =
                    DiscordBot.Client.Servers.Single(x => x.Name.Contains(Servers.SelectedItem.ToString())).AllChannels.Single(x => x.Name.Contains(Channels.SelectedItem.ToString()));
                var invite = target.CreateInvite().Result.ToString();
                MessageBox.Show("https://discord.gg/" + invite, "Invite");
            }
            catch (AggregateException)
            {
                MessageBox.Show("No Permission.", "invite");
            }
        }

        private void ownerbutton_Click(object sender, EventArgs e)
        {
            Server t = Servers.SelectedItem.ToString().ToServer(DiscordBot.Client.Servers);
            string ownername = t.Owner.Name;
            MessageBox.Show("Region: " + t.Region.Name + "\nHostname: " + t.Region.Hostname +"\nID: " + t.Region.Id + "\nPort: " + t.Region.Port + "\nUsers: " + t.UserCount +"\nChannels: " + t.ChannelCount + "\nOwner: " + t.Owner.Name);
        }

        private async void leaveserver_Click(object sender, EventArgs e)
        {
            Server t = Servers.SelectedItem.ToString().ToServer(DiscordBot.Client.Servers);
            await t.Leave();
            MessageBox.Show("Left server: " + t, "Disconnected");
            await Task.Delay(500);
            Servers.DataSource = DiscordBot.Client.Servers.Select(x => x.Name).ToList();
        }

        private void kickbutton_Click(object sender, EventArgs e)
        {
            try
            {
                User target2 =
                    DiscordBot.Client.Servers.Single(x => x.Name.Contains(Servers.SelectedItem.ToString()))
                        .AllChannels.Single(x => x.Name.Contains(Channels.SelectedItem.ToString()))
                        .Users.Single(x => x.Name.Contains(Users.SelectedItem.ToString()));
                target2.Kick();
                Task.Delay(500);
                Servers.DataSource = DiscordBot.Client.Servers.Select(x => x.Name).ToList();
            }
            catch (AggregateException)
            {
                MessageBox.Show("No permission.", "Error!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                User target2 = DiscordBot.Client.Servers.Single(x => x.Name.Contains(Servers.SelectedItem.ToString())).AllChannels.Single(x => x.Name.Contains(Channels.SelectedItem.ToString())).Users.Single(x => x.Name.Contains(Users.SelectedItem.ToString()));
                target2.Server.Ban(target2);
                Task.Delay(500);
                Servers.DataSource = DiscordBot.Client.Servers.Select(x => x.Name).ToList();
            }
            catch (AggregateException)
            {
                MessageBox.Show("No permission.", "Error!");
            }

        }
    }
}
