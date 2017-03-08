using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Commands;
using EncryptStringSample;
using Color = System.Drawing.Color;
using Discord.Audio;
using NAudio.Wave;
using SharpUpdate;


//Our namespace. This is where all begins!
namespace DiscordBot2
{
    public partial class DiscordBot : Form, ISharpUpdatable
    {
        //Here we're implementing a few fields:a textwriter, 2 booleans, 2 timers and our DiscordClient named Client.
        //The Writer is used to set our Console inside the form.
        //The Booleans have no use as of now.
        //The Timers are used for updating the sever, channel and user counts and to set our client's state to idle.
        public TextWriter Writer;
        public bool IsSearching;
        public static bool IsImportant;
        public static System.Threading.Timer DummyTimer;
        public static System.Threading.Timer DummyTimer2;
        public static System.Threading.Timer DummyTimer3;
        public static DiscordClient Client;
        public int Case;
        public static bool IsStreaming;
        public static bool Gamechanging = true;
        private SharpUpdater updater;

        public DiscordBot()
        {
            //Initializing our little fella.
            InitializeComponent();
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When this button is pressed, the Console will be cleared using an "unclean" method as you can see below.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@" __      __       .__                             ._.
/  \    /  \ ____ |  |   ____  ____   _____   ____| |
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \ |
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/\|
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >_
       \/       \/          \/            \/     \/\/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // It will also see if the Remember Token box is checked and if not.
            if (remembercheckbox.Checked)
            {
                File.WriteAllText(@"cache.txt", tokenbox.Text);
            }
            if (!remembercheckbox.Checked)
            {
                File.Delete(@"cache.txt");
            }
            // We want to enable the show list button after connecting. Not literally after connecting, but after pressing the button.
            listingbutton.Enabled = true;
            botsettingsbutton.Enabled = true;
            // Here we use the timer for the functions mentioned earlier.
            DummyTimer = new System.Threading.Timer(cb =>
            {
                Client.SetStatus(UserStatus.Idle);
            }, null, TimeSpan.FromSeconds(600), TimeSpan.FromSeconds(600)); // Every 600 seconds, aka 15 Minutes.
            DummyTimer2 = new System.Threading.Timer(cb =>
            {
                BeginInvoke(new Action(() => // Beginning an Invoke to avoid Corss-Threading errors.
                {
                    // Updating the counts for the labels.
                    userscount.Text = @"Users " + Client.Servers.Select(x => x.UserCount).Sum();
                    channelcount.Text = @"Channels: " + Client.Servers.Select(x => x.ChannelCount).Sum();
                    servercount.Text = @"Servers: " + Client.Servers.Count();
                }));


            }, null, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(3)); // This, every 3 sseconds.


            // We're finally connecting
            Client = new DiscordClient(x =>
            {
                x.AppName = "Discord Bot"; //App name
                x.AppUrl = "https://rithari.pw"; // The website of the app.
                x.LogLevel = LogSeverity.Info; // Used for logging (Log Method)
                x.LogHandler = Log; // Event handler for logging.
            });



            Client.MessageReceived += _client_MessageReceived; // Declaring what is what for the methods further down.
            Client.MessageDeleted += _client_MessageDeleted; // Message Deleted.
            Client.MessageUpdated += _client_MessageEdited; // Message edited.
            Client.UserBanned += _client_UserBanned; // Event handler for User Banned.
            Client.UserUnbanned += _client_UserUnbanned;// User unbanned.
            Client.UserJoined += _client_UserJoined; // User Joined
            Client.UserLeft += _client_UserLeft; // User left
            Client.RoleCreated += _client_RoleCreated; // Role created
            Client.RoleDeleted += _client_RoleDeleted; // Role deleted
            Client.RoleUpdated += _client_RoleUpdated; // Role updated
            Client.UserUpdated += _client_UserUpdated;
            Client.ChannelCreated += _client_ChannelCreated;
            Client.ChannelUpdated += _client_ChannelUpdated;
            Client.ChannelDestroyed += _client_ChannelDestroyed;
            Client.ProfileUpdated += _client_ProfileUpdated;
            Client.UsingAudio(x => // Opens an AudioConfigBuilder so we can configure our AudioService
            {
                x.Mode = AudioMode.Outgoing; // Tells the AudioService that we will only be sending audio
            });
            Client.UsingCommands(x =>
            {
                x.PrefixChar = '!'; //Prefix for commands, e.g. ! for !help.
                x.AllowMentionPrefix = true; //Mentioning your bot (@BotName) will act as PrefixChat (e.g. ! for !help / @BotName help)
                x.HelpMode = HelpMode.Public; // What is this?
            });

            var token = tokenbox.Text; //Telling the program that the tokenbox.Text is your token and store it in a variable.


            CreateCommands(); // We need to call this method in order to create and execute commands.

            Task.Run(async () => //A new Task, making sure you've actually entered a token, then waits 2 seconds, then connects and sets the colors for our count labels.
            {
                if (token == string.Empty)
                {
                    Console.WriteLine(@"Please enter a Token.");
                    return;
                }
                await Client.Connect("Bot " + token);
                await Task.Delay(2000);
               /* userscount.ForeColor = Color.Lime;
                channelcount.ForeColor = Color.Lime;
                servercount.ForeColor = Color.Lime;
                listingbutton.ForeColor = Color.Lime;*/
                
                while (true)
                {
                    //Permanently change between games in a time span of 15 seconds.
                    if (Gamechanging)
                    {
                        Client.SetGame(new[] { "!help", "Just Cause 2 Multiplayer", "Sad Satan", "DRAGONBALL XENOVERSE 2" }[new Random().Next(0, 4)]);
                        await Task.Delay(15000);
                    }

                }
            });

        }
        //A Method created for sending audio.
        public static void SendAudio(IAudioClient vClient)
        {
            var path = @"musicbot\";
            var files = Directory.GetFiles(path);
            var filePath = files[new Random().Next(0, files.Length)];
            // var filePath = new[] { @"C:\Users\ritha\Documents\music\a.mp3", @"C:\Users\ritha\Documents\music\b.mp3", @"C:\Users\ritha\Documents\music\c.mp3", @"C:\Users\ritha\Documents\music\d.mp3", @"C:\Users\ritha\Documents\music\e.mp3", @"C:\Users\ritha\Documents\music\f.mp3", @"C:\Users\ritha\Documents\music\g.mp3", @"C:\Users\ritha\Documents\music\h.mp3", @"C:\Users\ritha\Documents\music\i.mp3", @"C:\Users\ritha\Documents\music\j.mp3", @"C:\Users\ritha\Documents\music\k.mp3", @"C:\Users\ritha\Documents\music\l.mp3", @"C:\Users\ritha\Documents\music\m.mp3", @"C:\Users\ritha\Documents\music\n.mp3", @"C:\Users\ritha\Documents\music\o.mp3", @"C:\Users\ritha\Documents\music\p.mp3", @"C:\Users\ritha\Documents\music\a1.mp3", @"C:\Users\ritha\Documents\music\b1.mp3", @"C:\Users\ritha\Documents\music\c1.mp3", @"C:\Users\ritha\Documents\music\d1.mp3", @"C:\Users\ritha\Documents\music\e1.mp3", @"C:\Users\ritha\Documents\music\f1.mp3", @"C:\Users\ritha\Documents\music\g1.mp3", @"C:\Users\ritha\Documents\music\h1.mp3", @"C:\Users\ritha\Documents\music\i1.mp3", @"C:\Users\ritha\Documents\music\j1.mp3", @"C:\Users\ritha\Documents\music\k1.mp3", @"C:\Users\ritha\Documents\music\l1.mp3", @"C:\Users\ritha\Documents\music\m1.mp3", @"C:\Users\ritha\Documents\music\n1.mp3", @"C:\Users\ritha\Documents\music\o1.mp3", @"C:\Users\ritha\Documents\music\p1.mp3", @"C:\Users\ritha\Documents\music\x.mp3" }[new Random().Next(0, 33)];
            var channelCount = Client.GetService<AudioService>().Config.Channels; // Get the number of AudioChannels our AudioService has been configured to use.
            var OutFormat = new WaveFormat(48000, 16, channelCount); // Create a new Output Format, using the spec that Discord will accept, and with the number of channels that our client supports.
            using (var MP3Reader = new Mp3FileReader(filePath)) // Create a new Disposable MP3FileReader, to read audio from the filePath parameter
            using (var resampler = new MediaFoundationResampler(MP3Reader, OutFormat)) // Create a Disposable Resampler, which will convert the read MP3 data to PCM, using our Output Format
            {
                resampler.ResamplerQuality = 60; // Set the quality of the resampler to 60, the highest quality
                int blockSize = OutFormat.AverageBytesPerSecond / 50; // Establish the size of our AudioBuffer
                byte[] buffer = new byte[blockSize];
                int byteCount;

                while ((byteCount = resampler.Read(buffer, 0, blockSize)) > 0) // Read audio into our buffer, and keep a loop open while data is present
                {
                    if (byteCount < blockSize)
                    {
                        // Incomplete Frame
                        for (int i = byteCount; i < blockSize; i++)
                            buffer[i] = 0;
                    }
                    vClient.Send(buffer, 0, blockSize); // Send the buffer to Discord
                }

            }
        }
        public static void CreateCommands()
        {
            //Storing cService and assigning it to Client.GetService<CommandService>()
            var cService = Client.GetService<CommandService>();

            //Easily one of the most common commands used in bots these days. !ping will make the bot respond 'pong' as an example of pinging.
            cService.CreateCommand("ping").Description("Pings the bot").Do(async (e) =>
            {
                await e.Channel.SendMessage("pong");
            });
            //Summoning the bot into a voice chat, turning IsStreaming on so you don't double summon it, checking if it's enabled or not obviously, finding a channel called 'Music' and joining it. If there is none, post message asking for it to be made.
            cService.CreateCommand("summon")
             .Parameter("parameter", ParameterType.Unparsed)
             .Description("Summons Emilia to a voice channel and makes her a music source!")
             .Do(async (e) =>
             {

                 if (IsStreaming)
                 {
                     await e.Channel.SendMessage("I'm already playing music!");
                     return;
                 }
                 IsStreaming = true;
                 var voiceChannel = e.Server.FindChannels("Music").FirstOrDefault();
                 if (voiceChannel == null)
                 {
                     await e.Channel.SendMessage("Yeah you kinda need to create a voicechannel called 'Music'. ");
                     return;
                 }
                 //Additionally, we create an autoplay using a timer.
                 var vClient = await Client.GetService<AudioService>().Join(voiceChannel);
                 var timer = new System.Timers.Timer();
                 timer.Interval = 500;
                 timer.AutoReset = false;
                 timer.Elapsed += (o, x) =>
                 {
                     SendAudio(vClient);
                     timer.Start();
                 };
                 timer.Start();
                 //Telling the user we've been summoned successfully, though this is called regardless of the success.
                 await e.Channel.SendMessage($"I've been summoned to {voiceChannel.Name}.");

             });
            //Same as above, just disconnecting from the voice channel.
            cService.CreateCommand("unsummon")
                .Description("Unsummons Emilia.")
                .Do(async (e) =>
                {
                    if (IsStreaming == false)
                    {
                        await e.Channel.SendMessage("I'm not even in any Channel!");
                        return;
                    }
                    IsStreaming = false;
                    var voiceChannel = e.Server.FindChannels("Music").FirstOrDefault();
                    await Client.GetService<AudioService>().Leave(voiceChannel);
                    await e.Channel.SendMessage("I've been unsummoned.");

                });
            //Pretty useless command 'borrowed' from Discord API's bot in Discord.Net. Tells you what to do when your code doesn't run.
            cService.CreateCommand("doesntwork").Description("Troubleshooting").Do(async (e) =>
            {
                await e.Channel.SendMessage("doesntwork: If your code 'doesn't run', that can mean one of literally a million things. In order for us to help you, you need to provide an error report `!errors`. If you don't have an error, learn how to debug your code. Breakpoints and all of Visual Studio's debugging tools are available to you, you should learn how to use them.We can't help you with only you saying 'it doesn't work'.");
            });
            //Same thing as above, for errors.
            cService.CreateCommand("errors")
                .Description("Troubleshooting")
                .Do(async (e) =>
            {
                await e.Channel.SendMessage("errors: __How to do Error Reports__:\n1) Include a Stack Trace\n2) Include the full Error Message\n3) Include the source where the exception occurred, and some context\nIf you do not provide these, we cannot help you.");
            });
            //Clears the chat, deletes as many messages as specified in the messagecount parameter.
            cService.CreateCommand("clear")
                .Parameter("messagecount", ParameterType.Unparsed)
                .Description("Clear out the messages in your channel.")
                .Do(async (e) =>
                {
                    if (e.Message.User.Id != 127504308156628992)
                    {
                        await e.Channel.SendMessage("Unauthorized.");
                        return;

                    }
                    int messageToCleanAmount = 0;
                    if (int.TryParse(e.Message.Text.Remove(0, 7), out messageToCleanAmount))
                    {
                        await e.Channel.DownloadMessages(messageToCleanAmount);

                        Discord.Message[] sortedMessages = e.Channel.Messages.OrderByDescending(item => item.Timestamp).ToArray();    //Sort the messages
                        for (int i = 0; i <= messageToCleanAmount; i++)
                        {
                            if (i >= sortedMessages.Length)
                                break;
                            Discord.Message m = sortedMessages[i];
                            await m.Delete();
                        }
                    }
                });
            //Makes the bot repeat what you have said in the parameter.
            cService.CreateCommand("echo").Description("echoes \n [-] represents an optional argument.\n e.g. 'my name is Lukas. <--- parameter'").Parameter("user", ParameterType.Unparsed).Do(async (e) =>
            {
                var toReturn = $"{e.GetArg("user")}";

                if (toReturn.Length > 10)
                {
                    await Task.Delay(5000);
                }
                else
                {
                    await Task.Delay(1500);
                }
                await e.Channel.SendMessage("```fix\n" + toReturn + "```");
            });

            //Pulls the permissions from the server, and tells you what permission your target (specified in parameter through mention) has.
            cService.CreateCommand("getperms").Description("Output specified user's permission").Parameter("user", ParameterType.Unparsed).Do(async (e) =>
            {
                foreach (User u in e.Server.Users)
                {
                    if (e.Message.Text.Substring(9).Contains(u.Name))
                    {
                        //Checking if the values are true or false.
                        string adminPerm = u.ServerPermissions.Administrator ? "Yes" : "No";
                        string banPerm = u.ServerPermissions.BanMembers ? "Yes" : "No";
                        string kickPerm = u.ServerPermissions.KickMembers ? "Yes" : "No";
                        string changeNickNamePerm = u.ServerPermissions.ChangeNickname ? "Yes" : "No";
                        string createInstantInvitePerm = u.ServerPermissions.CreateInstantInvite ? "Yes" : "No";
                        string manageChannelsPerm = u.ServerPermissions.ManageChannels ? "Yes" : "No";
                        string manageMsgsPerm = u.ServerPermissions.ManageMessages ? "Yes" : "No";
                        string manageNicknamesPerm = u.ServerPermissions.ManageNicknames ? "Yes" : "No";
                        string manageRolesPerm = u.ServerPermissions.ManageRoles ? "Yes" : "No";
                        string moveMembersPerm = u.ServerPermissions.MoveMembers ? "Yes" : "No";
                        //Telling the user that x has y permissions.
                        await e.Channel.SendMessage("```fix\n" + u.Mention + "\n" + "Server: " + e.Server.Name + "\n" + u.Name + "'s Permissions: " + "\nIs Admin: " + adminPerm + "\nCan Ban Members: " + banPerm + "\nCan Kick Members: " + kickPerm + "\nCan Change Nickname: " + changeNickNamePerm + "\nCan Create Instant Invites: " + createInstantInvitePerm + "\nCan Manage Channels: " + manageChannelsPerm + "\nCan Manage Messages: " + manageMsgsPerm + "\nCan Manage Nicknames: " + manageNicknamesPerm + "\nCan Manage Roles: " + manageRolesPerm + "\nCan Move Members: " + moveMembersPerm + "```");
                    }

                }
            });

            //Same as above, just for yourself.
            cService.CreateCommand("myperms").Description("Outputs your permissions on this server.").Do(async (e) =>
            {

                string adminPerm = e.User.ServerPermissions.Administrator ? "Yes" : "No";
                string banPerm = e.User.ServerPermissions.BanMembers ? "Yes" : "No";
                string kickPerm = e.User.ServerPermissions.KickMembers ? "Yes" : "No";
                string changeNickNamePerm = e.User.ServerPermissions.ChangeNickname ? "Yes" : "No";
                string createInstantInvitePerm = e.User.ServerPermissions.CreateInstantInvite ? "Yes" : "No";
                string manageChannelsPerm = e.User.ServerPermissions.ManageChannels ? "Yes" : "No";
                string manageMsgsPerm = e.User.ServerPermissions.ManageMessages ? "Yes" : "No";
                string manageNicknamesPerm = e.User.ServerPermissions.ManageNicknames ? "Yes" : "No";
                string manageRolesPerm = e.User.ServerPermissions.ManageRoles ? "Yes" : "No";
                string moveMembersPerm = e.User.ServerPermissions.MoveMembers ? "Yes" : "No";
                await
                    e.Channel.SendMessage("```fix\n" + e.User.Mention + "\n" + "Server: " + e.Server.Name + "\nYour Permissions:" + "\nIs Admin: " + adminPerm + "\nCan Ban Members: " + banPerm + "\nCan Kick Members: " + kickPerm + "\nCan Change Nickname: " + changeNickNamePerm + "\nCan Create Instant Invites: " + createInstantInvitePerm + "\nCan Manage Channels: " + manageChannelsPerm + "\nCan Manage Messages: " +
                                          manageMsgsPerm + "\nCan Manage Nicknames: " + manageNicknamesPerm + "\nCan Manage Roles: " + manageRolesPerm + "\nCan Move Members: " + moveMembersPerm + "```");
            });

            //Cleverly doesn't interrupt the auto game change set in the beginning, don't know why this is still a feature, but could be used when auto game changing is disabled trough the form.
            cService.CreateCommand("setgame").Description("Sets current game.").Parameter("parameter", ParameterType.Multiple).Do(async (e) =>
            {
                if (e.Message.User.Id == 127504308156628992)
                {
                    string game = e.Message.Text.Substring(9);
                    Client.SetGame(game);

                    await e.Channel.SendMessage("Game set.");
                }
                else
                {

                    await e.Channel.SendMessage("```fix\n" + "Unauthorized." + "```");
                }
            });

            //Closes the application. As always, for those type of commands, it checks whether you're authorized or not.
            cService.CreateCommand("shutdown").Description("Executes shutdown sequence.").Do(async (e) =>
            {
                if (e.Message.User.Id == 127504308156628992)
                {

                    await e.Channel.SendMessage("Shutting down...");
                    await Task.Delay(1000);
                    Environment.Exit(0);
                }
                else
                {

                    await e.Channel.SendMessage("```fix\n" + "Unauthorized." + "```");
                }

            });


            cService.CreateCommand("google").Description("Google for Discord!").Parameter("search", ParameterType.Unparsed).Do(async (e) =>
            {
                await e.Channel.SendMessage("https://www.google.com/search?q=" + Regex.Replace(Regex.Replace(Regex.Split(" " + e.Message.Text, @"\!google\s+")[1], @"\%|\$|\&|\@|\/|\;|\?|\:|\=", ""), @"\s+", "+"));
            });


            cService.CreateCommand("lmgtfy").Description("Let me Google that for you for Discord!").Parameter("search", ParameterType.Unparsed).Do(async (e) =>
            {
                await e.Channel.SendMessage("http://lmgtfy.com/?q=" + Regex.Replace(Regex.Replace(Regex.Split(" " + e.Message.Text, @"\!lmgtfy\s+")[1], @"\%|\$|\&|\@|\/|\;|\?|\:|\=", ""), @"\s+", "+"));
            });


            cService.CreateCommand("bool").Description("Switches a boolean in the source code.").Parameter("bool", ParameterType.Unparsed).Do(async (e) =>
            {

                var toReturn = $"{e.GetArg("bool")}";
                switch (toReturn)
                {
                    case "isImportant":
                        if (IsImportant == false)
                        {
                            IsImportant = true;
                            await e.Channel.SendMessage("Bool value = true.");
                            return;
                        }
                        if (IsImportant)
                        {
                            IsImportant = false;
                            await e.Channel.SendMessage("Bool value = false.");
                        }
                        break;
                    case "isFaggot":
                        {
                            await e.Channel.SendMessage("Bool value = true.");
                            break;
                        }
                    default:
                        await e.Channel.SendMessage("```fix\n" + "Your input (" + toReturn + ") is not a boolean." + "```");
                        return;
                }



            });


            cService.CreateCommand("encrypt").Description("Encrypt your message uniquely.\nUsage: !encrypt STRINGTOENCRYPT").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {

                var toReturn = StringCipher.Encrypt(Regex.Replace(Regex.Split(" " + e.Message.Text, @"!encrypt\s+")[1], @"\'", " "), "123");

                var message = await e.Channel.SendMessage("Processing...");
                await Task.Delay(500);
                await message.Edit("```fix\n" + toReturn + "```");
            });


            cService.CreateCommand("imgencrypt").Description("Encrypt images. -> Doesn't work.").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {
                //What we're using in this command.
                string SaltValue = "aaa";
                string password = "123";
                var toReturn = e.GetArg("parameter");

                //Starting a WebClient to download the image specified in the parameter, which is unparsed.
                using (WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(toReturn), @"image35.png");
                }

                //Letting the User know we've downloaded the file, successfully, after this point, if the file isn't an image, it will stop working.
                await e.Channel.SendMessage("Just downloaded the file.");
                await Task.Delay(3000);

                //Here we're creating an Image named img which is the png we've just downloaded and then we convert it into a byte array.
                Image img = Image.FromFile(@"image35.png");
                byte[] bArr = ImageToByteArray(img);

                //Creating a variable 'encryptedbytes' which using the Rijndael algorithm encrypts our image which we previously converted into a byte array.
                var encryptedbytes = ImageCipher.RijndaelHelper.EncryptBytes(bArr, password, SaltValue);

                //Telling the User we've encrypted the file successfully, here it stops working, probably because it will be unable to convert the encrypted byte array into an image.
                await e.Channel.SendMessage("Just encrypted it.");
                await Task.Delay(3000);
                await e.Channel.SendMessage("Sending the file...");

                //Encrypted byte array into a binary file.
                var stream = new MemoryStream(encryptedbytes);



                //Sending it to the Channel.
                await e.Channel.SendFile("encryptedimage.bin", stream);
                await Task.Delay(3000);

                //Getting rid of unecessary image variables.
                img.Dispose();


            });


            cService.CreateCommand("imgdecrypt").Parameter("parameter", ParameterType.Unparsed).Description("Decrypt an encrypted image, usually .bin").Do(async (e) =>
            {
                //What we're using in this command.
                var toReturn = e.GetArg("parameter");
                string SaltValue = "aaa";
                string password = "123";
                byte[] bytes;

                //Using Webclient which awaits the download before continuing.
                using (var client = new WebClient())
                {
                    bytes = await Task.Run(() => client.DownloadData(new Uri(toReturn)));
                }

                //Letting the User know we've downloaded the file, successfully, after this point, if the file isn't compatible, it will stop working.
                await e.Channel.SendMessage("Just downloaded the file.");
                await Task.Delay(3000);

                //Declaring that the variable bytes is equal to the .bin content decrypting it, storing it in yet another variable and telling the user we've decrypted the file.
                var decrypteddbytes = ImageCipher.RijndaelHelper.DecryptBytes(bytes, password, SaltValue);
                await e.Channel.SendMessage("Just decrypted it.");
                await Task.Delay(3000);

                //Finally, we take our decrypted bytes and turn them into an image.
                Image img = ByteArrayToImage(decrypteddbytes);

                //Now we save it as a .png and send it to the user.
                img.Save(@"decryptedimage.png");
                await e.Channel.SendFile(@"decryptedimage.png");


            });


            cService.CreateCommand("decrypt").Parameter("parameter", ParameterType.Unparsed).Description("Decrypt your message uniquely.\nUsage: !decrypt ENCRYPTEDSTRING\nOnly decrypts strings encrypted by this bot.").Do(async (e) =>
            {

                Discord.Message k = await e.Channel.SendMessage("Processing...");
                await Task.Delay(1000);
                await k.Edit("```fix\n" + StringCipher.Decrypt(Regex.Split(" " + e.Message.Text, @"\!decrypt")[1], "123") + "```");
            });


            cService.CreateCommand("8ball").Parameter("parameter", ParameterType.Unparsed).Description("Magic 8 Ball for Discord!").Do(async (e) =>
            {

                string answer = new[]
                    {
                        "It is certain.", "It is decidedly so.", "Without a doubt.", "Yes, definitely.", "You may rely on it.", "As I see it, yes.", "Most likely.", "Outlook good.", "Yes.", "Signs point to yes.", "Reply hazy to try again.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.", "My reply is no.", "Outlook not so good.", "Very doubtful.",
                        "My sources say no."
                    }[new Random().Next(0, 20)];

                await e.Channel.SendMessage((Regex.IsMatch(e.Message.Text.ToLower(), @"\!8ball\s+.*?") ? answer : "```fix\nYou must specify a question.```"));
            });


            cService.CreateCommand("roulette").Description("Russian Roulette for Discord!").Do(async (e) =>
            {
                await e.Channel.SendMessage(new[] { ":gun: :boom:, you died! :skull:\r\n", ":gun: *click*, no bullet in there for you this round.\r\n", ":gun: *click*, no bullet in there for you this round.\r\n", ":gun: *click*, no bullet in there for you this round.\r\n" }[new Random().Next(0, 4)]);
            });


            cService.CreateCommand("yt").Parameter("parameter", ParameterType.Unparsed).Description("YouTube search for Discord!").Do(async (e) =>
            {

                string html = new WebClient().DownloadString("https://www.youtube.com/results?search_query=" + Regex.Replace(Regex.Split(" " + e.Message.Text, @"\!yt\s+")[1], @"\s+", "+"));
                await e.Channel.SendMessage("https://www.youtube.com/watch?" + Regex.Split(Regex.Split(html, @"\/watch\?")[1], "\"")[0]);
            });


            cService.CreateCommand("define").Description("Urban Dictionary for Discord!").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {

                Discord.Message d = await e.Channel.SendMessage("Searching for definitions...");

                string url = new WebClient().DownloadString("http://www.urbandictionary.com/define.php?term=" + Regex.Replace(Regex.Split(" " + e.Message.Text, @"\s+\!define\s+")[1], @"\s+", "+"));

                url = Regex.Split(url, @"\<div\s+class\=.*?meaning.*?\>")[1].Split('<')[0];

                await d.Edit(":notebook_with_decorative_cover:" + "`[Urban Dictionary]`" + Regex.Replace(url, @"&#39;|\<.*?\>|&quot;|&amp;|â€™|â€œ|!â€", "\0"));


            });

            cService.CreateCommand("quote").Description("Quote someone in Discord! \n Usage: !quote @user quote.").Parameter("parameter", ParameterType.Required).Parameter("parameter2", ParameterType.Unparsed).Do(async (e) =>
            {
                var user = e.Server.FindUsers(e.GetArg("parameter")).FirstOrDefault();
                await e.Channel.SendMessage($"```fix\nQuote from {user}\n{e.GetArg(1)}```");
            });

            cService.CreateCommand("lovecalc").Description("Love calculations for Discord!\nUsage: !lovecalc name, name2 or !lovecalc name and name2").Parameter("victim and victim2", ParameterType.Unparsed).Do(async (e) =>
            {

                string cacheWords = Regex.Split(" " + e.Message.Text, @"\!lovecalc\s+")[1];
                string[] words = Regex.Split(cacheWords, @"\s+and\s+|\,\s+");
                cacheWords = new WebClient().DownloadString("https://www.lovecalculator.com/love.php?name1=" + words[0] + "&name2=" + words[1]);
                await e.Channel.SendMessage(":cupid: Love chance between " + words[0] + " and " + words[1] + ": `" + Regex.Split(Regex.Split(cacheWords, @"\<div\s+class\=.*?result\s+score.*?\>")[1], @"\<\/div\>")[0] + "`");
            });


            cService.CreateCommand("code").Description("Quickly paste code\n Usage: !code code\n It's in CSharp only at the moment.").Parameter("code", ParameterType.Unparsed).Do(async (e) =>
            {

                await e.Message.Delete();
                string wewlad = "```csharp\n";
                string wewlad2 = "```";
                var toReturn = $"{e.GetArg("code")}";

                if (toReturn.Length > 10)
                {
                    await Task.Delay(5000);
                }
                else
                {
                    await Task.Delay(1500);
                }
                await e.Channel.SendMessage(wewlad + toReturn + wewlad2);
            });


            cService.CreateCommand("ban").Description("Ban for Discord!").Parameter("user", ParameterType.Unparsed).Do(async (e) =>
            {
                if (e.Message.User.Id == 127504308156628992)
                {
                    User u = null;
                    string findUser = e.Args[0];
                    if (!string.IsNullOrWhiteSpace(findUser))
                    {
                        if (e.Message.MentionedUsers.Count() == 1)
                            u = e.Message.MentionedUsers.First();
                        else if (e.Server.FindUsers(findUser).Any())
                            u = e.Server.FindUsers(findUser).First();
                        else
                            await e.Channel.SendMessage($"```fix\n" + "I was unable to find a user like `{findUser}`" + "```");
                    }

                    if (u != null)
                    {
                        Console.WriteLine(u);
                        await e.Server.Ban(u, 30);
                    }
                }
                else
                {
                    await e.Channel.SendMessage("```fix\nUnauthorized```");
                }
            });


            cService.CreateCommand("unban").Description("Unban for Discord!").Parameter("user", ParameterType.Unparsed).Do(async (e) =>
            {
                await e.Server.Unban((await e.Server.GetBans()).Single(x => x.Name == Regex.Split(e.Message.Text, @"\@")[1]));
            });


            cService.CreateCommand("joke").Description("The biggest joke in the universe.").Do(async (e) =>
            {
                await e.Channel.SendMessage("RobbieW");
            });


            cService.CreateCommand("timer").Description("Timer to set reminders!\nUsage: !timer xxx seconds/minutes/hours ").Parameter("text", ParameterType.Unparsed).Do(async e =>
            {
                string[] seperatedWords = e.Message.Text.Split(' ');
                string wait = seperatedWords[1];
                if (seperatedWords.Length >= 3 && int.Parse(wait) > 0)
                {
                    if (seperatedWords.Length >= 3 && seperatedWords[2] == "seconds" || seperatedWords.Length >= 3 && seperatedWords[2] == "second")
                    {
                        if (seperatedWords.Length == 3)
                        {
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 1000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off!");
                        }
                        else
                        {
                            string reason = e.Message.Text.Substring(seperatedWords[0].Length + seperatedWords[1].Length + seperatedWords[2].Length + 3);
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you about **" + reason + "** in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 1000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off! **'" + reason + "'**");
                        }
                    }
                    else if (seperatedWords.Length >= 3 && seperatedWords[2] == "minutes" || seperatedWords.Length >= 3 && seperatedWords[2] == "minute")
                    {
                        if (seperatedWords.Length == 3)
                        {
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 60000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off.");
                        }
                        else
                        {
                            string reason = e.Message.Text.Substring(seperatedWords[0].Length + seperatedWords[1].Length + seperatedWords[2].Length + 3);
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you about **" + reason + "** in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 60000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off! **'" + reason + "'**");
                        }
                    }
                    else if (seperatedWords.Length >= 3 && seperatedWords[2] == "hours" || seperatedWords.Length >= 3 && seperatedWords[2] == "hour")
                    {
                        if (seperatedWords.Length == 3)
                        {
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 3600000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off.");
                        }
                        else
                        {
                            string reason = e.Message.Text.Substring(seperatedWords[0].Length + seperatedWords[1].Length + seperatedWords[2].Length + 3);
                            await e.Channel.SendMessage(e.User.Mention + ", I will notify you about **" + reason + "** in **" + seperatedWords[1] + " " + seperatedWords[2] + "**");
                            await Task.Delay(int.Parse(wait) * 3600000);
                            await e.Channel.SendMessage(e.User.Mention + ", Ring ring! Your timer has gone off! **'" + reason + "'**");
                        }
                    }
                    else
                    {
                        await e.Channel.SendMessage("Invalid time.");
                    }
                }
                else if (seperatedWords.Length >= 3 && int.Parse(wait) < 0)
                {
                    await e.Channel.SendMessage("```fix\nSorry, " + e.User.Mention + ", I'm not a time traveller.```");
                }
                else if (e.GetArg("text") == "")
                {
                    await e.Channel.SendMessage("```fix\nInvalid time.```");
                }
                else
                {
                    await e.Channel.SendMessage("```fix\nInvalid time.```");
                }
                Console.WriteLine(@"Reminded someone of something in " + e.Server.Name);
            });


            cService.CreateCommand("color").Description("Change the color of your name.\n !color colorname\n Available colors: ``` red,orange,purple,green,blue,black,white,cyan,lime,pink,yellow,lightred,lavender,salmon,darkpurple,darkblue ```").Parameter("color", ParameterType.Unparsed).Do(async (e) =>
            {
                if (e.Server.CurrentUser.ServerPermissions.ManageRoles)
                {
                    var color = e.GetArg("color").ToLower();
                    var roletoassign = e.Server.Roles.SingleOrDefault(x => x.Name.ToLower() == color);

                    var colorlist = new List<string> { "red", "orange", "purple", "green", "blue", "black", "white", "cyan", "lime", "pink", "yellow", "lightred", "lavender", "salmon", "darkpurple", "darkblue" };
                    var rolestoremove = e.User.Roles.Where(x => colorlist.Contains(x.Name.ToLower())).ToArray();
                   // if (colorlist.Any(x => !e.Server.Roles.Select(tx => tx.Name).Contains(x))) await e.Server.CreateRole(colorlist.Single(x => !e.Server.Roles.Select(l => l.Name).Contains(x)), color: color);

                    if (roletoassign != null)
                    {

                        if (roletoassign.Permissions.Administrator || roletoassign.Permissions.BanMembers || roletoassign.Permissions.DeafenMembers || roletoassign.Permissions.KickMembers || roletoassign.Permissions.ManageChannels || roletoassign.Permissions.ManageMessages || roletoassign.Permissions.ManageNicknames || roletoassign.Permissions.ManageRoles || roletoassign.Permissions.ManageServer ||
                            roletoassign.Permissions.MuteMembers || roletoassign.Permissions.MoveMembers)

                        {

                            await e.Channel.SendMessage($"The color role {roletoassign.Name} has higher permissions than regular roles. To fix this, remove any kind of moderation/administration permissions from the color role and try again.");
                            return;
                        }
                        if (colorlist.All(x => x != Regex.Split(" " + e.Message.Text, @"\!color\s+")[1].ToLower()))
                        {

                            await e.Channel.SendMessage($"{roletoassign.Name} isn't a color role.");
                            return;
                        }

                        await e.User.RemoveRoles(rolestoremove);
                        await Task.Delay(500);
                        await e.User.AddRoles(roletoassign);
                        await e.Channel.SendMessage($"You are now {roletoassign.Name}");
                    }
                    else
                    {
                        await e.Channel.SendMessage($"The color {color} does not exist.\n Available colors: ``` red,orange,purple,green,blue,black,white,cyan,lime,pink,yellow,lightred,lavender,salmon,darkpurple,darkblue ```");
                    }
                }
                else
                {

                    await e.Channel.SendMessage("No permission.");
                }
            });

            cService.CreateCommand("mute").Parameter("parameter", ParameterType.Unparsed).Description("Mutes User - Warframe Server.").Do(async (e) =>
            {
                var mutedrole = new List<string> { "muted" };
                if (e.Message.User.Id == 127504308156628992)
                {
                    User u = null;
                    string findUser = e.Args[0];
                    if (!string.IsNullOrWhiteSpace(findUser))
                    {
                        if (e.Message.MentionedUsers.Count() == 1)
                            u = e.Message.MentionedUsers.First();
                        else if (e.Server.FindUsers(findUser).Any())
                            u = e.Server.FindUsers(findUser).First();
                        else
                            await e.Channel.SendMessage($"```fix\n" + "I was unable to find a user like {findUser}" + "```");
                    }

                    if (u != null)
                    {
                        var removeroles = u.Roles.ToArray();
                        Console.WriteLine(u);
                        await u.RemoveRoles(removeroles);
                        await Task.Delay(1000);
                        var muted = e.Server.Roles.Where(x => mutedrole.Contains(x.Name.ToLower())).ToArray();
                        await u.AddRoles(muted);
                        await e.Channel.SendMessage(e.User.Mention + " muted " + u.Mention + ".");

                    }
                }
                else
                {
                    await e.Channel.SendMessage("```fix\nUnauthorized```");
                }

            });


            cService.CreateCommand("unmute").Description("Unmutes User - Warframe Server.").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {
                if (e.Message.User.Id == 127504308156628992)
                {
                    User u = null;
                    string findUser = e.Args[0];
                    if (!string.IsNullOrWhiteSpace(findUser))
                    {
                        if (e.Message.MentionedUsers.Count() == 1)
                            u = e.Message.MentionedUsers.First();
                        else if (e.Server.FindUsers(findUser).Any())
                            u = e.Server.FindUsers(findUser).First();
                        else
                            await e.Channel.SendMessage($"```fix\n" + "I was unable to find a user like {findUser}" + "```");
                    }

                    if (u != null)
                    {
                        var removeroles = u.Roles.ToArray();
                        Console.WriteLine(u);
                        await u.RemoveRoles(removeroles);
                        await Task.Delay(1000);
                        await e.Channel.SendMessage(e.User.Mention + " unmuted " + u.Mention + ".");

                    }
                }
                else
                {
                    await e.Channel.SendMessage("```fix\nUnauthorized```");
                }
            });


            cService.CreateCommand("uncolor").Description("Removes your color role, if any.").Do(async (e) =>
            {
                var colorlist = new List<string> { "red", "orange", "purple", "green", "blue", "black", "white", "cyan", "lime", "pink", "yellow", "lightred", "lavender", "salmon", "darkpurple", "darkblue" };
                var roles = e.User.Roles.Where(x => colorlist.Contains(x.Name.ToLower())).ToArray();
                await e.User.RemoveRoles(roles);
            });


            cService.CreateCommand("steamp").Description("Your steam profile banner for Discord!").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {
                if (Regex.IsMatch(e.Message.Text, @"\!steamp\s+\w+"))
                {
                    try //Try and create a banner
                    {
                        //Inherit idisposable with webclient instance
                        using (WebClient download = new WebClient())
                        {
                            //Split the input of the user to get the name of the person
                            string split = Regex.Split(e.Message.Text, @"steamp\s+")[1];

                            //Download the signature
                            await download.DownloadFileTaskAsync(new Uri("http://steamsigmaker.de/komedy/" + split + ".png"), "steam.png");

                            //Load the steam png into a new bitmap image
                            Bitmap f = new Bitmap("steam.png");

                            //Check if the pixels at 60 width 60 height are a certain color
                            //This is to determine if the picture says it couldnt find a user
                            if (f.GetPixel(60, 60).R == 242)
                            {
                                //Return an error message saying the user does not exist
                                await e.Channel.SendMessage("```fix\nThat user does not exist, try to use the custom profile link instead.```");
                            }

                            //If the user exists
                            else
                            {
                                //Send the file
                                await e.Channel.SendFile("steam.png");
                            }

                            //Dispose the bitmap memory
                            f.Dispose();
                        }
                    }
                    //If the program downloads to much it will raise exceptions
                    //Catch it and report the error to the user
                    catch (Exception)
                    {
                        //Send error message
                        await e.Channel.SendMessage("```fix\nA banner is already being made```");
                    }
                }
                //If they entered it correctly
                else
                {
                    await e.Channel.SendMessage("```fix\nIncorrect format, use it like this: !steamp name```");
                }
            });


            cService.CreateCommand("mal").Description("My anime list for Discord!").Parameter("parameter", ParameterType.Unparsed).Do(async (e) =>
            {
                //If they have keywords in their string
                if (Regex.IsMatch(e.Message.Text, @"\!mal\s+\{\w+\}\s+\w+"))
                {
                    //Implement idisposable with the new instance of webclient
                    using (WebClient mal = new WebClient())
                    {
                        //Download the html by taking the users keywords and replacing all the spaces with plus symbols so it doesnt break the string
                        string html = await mal.DownloadStringTaskAsync("http://myanimelist.net/search/all?q=" + Regex.Replace(Regex.Split(" " + e.Message.Text, @"\!mal\s+\{\w+\}\s+")[1], @"\s+", "+"));

                        //Root through the html to find the link
                        string match = Regex.Replace(Regex.Matches(html, "http\\:\\/\\/myanimelist\\.net\\/" + Regex.Split(e.Message.Text, @"\{|\}")[1] + "\\/\\d+\\/.*?\"")[0].Value, "\\<a\\s+href\\=.|\"", "");

                        //Send the link in the chat
                        await e.Channel.SendMessage("Anime: " + match);
                    }
                }
                //If they entered the command wrong
                else
                {
                    //Send an error message in
                    await e.Channel.SendMessage("`!mal {manga/anime} anime name`");
                }
            });


            cService.CreateCommand("memegen").Description("Meme generator for Discord!\n Usage: phrase1, phrase2 {imageurl}").Parameter("phrase1, phrase2 {imageurl}", ParameterType.Unparsed).Do(async (e) =>
            {

                await Task.Delay(2000);
                if (Regex.IsMatch(e.Message.Text, @"\!memegen\s+.*?\,\s+.*?\s+\{.*?\.\w{3}\}"))
                {
                    string[] wordsmeme = Regex.Split(Regex.Split(" " + e.Message.Text, @"\!memegen\s+")[1], @"\,\s+");
                    string uri = Regex.Split(e.Message.Text, @"\!memegen\s+.*?\,\s+.*?\s+\{")[1];
                    new WebClient().DownloadFile(uri.Substring(0, uri.Length - 1), "doge.jpg");
                    new WebClient().Dispose();
                    Bitmap img = (Bitmap)Image.FromFile("doge.jpg");
                    using (Graphics editor = Graphics.FromImage(img))
                    {
                        using (var impact = new Font("Impact", (img.Height + img.Width) / 26))
                        {
                            editor.DrawString(wordsmeme[0].InsertNewLineAfterEvery(17), impact, Brushes.GhostWhite, new PointF(img.Width / 2, 10f), new StringFormat() { Alignment = StringAlignment.Center });

                            editor.DrawString(wordsmeme[1].Split(new char[] { '{' })[0].InsertNewLineAfterEvery(16), impact, Brushes.GhostWhite, new PointF(img.Width / 2, img.Height / 1.4f), new StringFormat() { Alignment = StringAlignment.Center });
                            impact.Dispose();
                        }
                        editor.Dispose();
                    }
                    img.Save(@"dogetwo.jpg", ImageFormat.Jpeg);
                    img.Dispose();
                    await e.Channel.SendFile(@"dogetwo.jpg");
                }
                else
                {
                    await e.Channel.SendMessage(@"Incorrect format, use it like this: `!memegen phrase1, phrase2 {https://image.jpg}`");
                }
            });
        }

        public void Log(object sender, LogMessageEventArgs e)
        {

            Console.WriteLine($"[{e.Severity}] [{e.Source}] {e.Message}");
        }

        public async void _client_RoleCreated(object sender, RoleEventArgs e)
        {
            //Permissions.
            string adminPerm = e.Role.Permissions.Administrator ? "Yes" : "No";
            string banPerm = e.Role.Permissions.BanMembers ? "Yes" : "No";
            string kickPerm = e.Role.Permissions.KickMembers ? "Yes" : "No";
            string changeNickNamePerm = e.Role.Permissions.ChangeNickname ? "Yes" : "No";
            string createInstantInvitePerm = e.Role.Permissions.CreateInstantInvite ? "Yes" : "No";
            string manageChannelsPerm = e.Role.Permissions.ManageChannels ? "Yes" : "No";
            string manageMsgsPerm = e.Role.Permissions.ManageMessages ? "Yes" : "No";
            string manageNicknamesPerm = e.Role.Permissions.ManageNicknames ? "Yes" : "No";
            string manageRolesPerm = e.Role.Permissions.ManageRoles ? "Yes" : "No";
            string moveMembersPerm = e.Role.Permissions.MoveMembers ? "Yes" : "No";


                var rithari = e.Server.GetUser(127504308156628992);
                await rithari.SendMessage($"Warning, {e.Role.Name} has been created, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));
                await rithari.SendMessage("```fix\n" + "Server: " + e.Server.Name + "\n" + e.Role.Name + "'s Permissions: " + "\nIs Admin: " + adminPerm + "\nCan Ban Members: " + banPerm + "\nCan Kick Members: " + kickPerm + "\nCan Change Nickname: " + changeNickNamePerm + "\nCan Create Instant Invites: " + createInstantInvitePerm + "\nCan Manage Channels: " + manageChannelsPerm + "\nCan Manage Messages: " + manageMsgsPerm + "\nCan Manage Nicknames: " + manageNicknamesPerm + "\nCan Manage Roles: " + manageRolesPerm + "\nCan Move Members: " + moveMembersPerm + "```");

                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                await logChannel.SendTTSMessage($"Warning, {e.Role.Name} has been created, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));

        }

        public async void _client_RoleDeleted(object sender, RoleEventArgs e)
        {

                var rithari = e.Server.GetUser(127504308156628992);
                await rithari.SendMessage($"Warning, {e.Role.Name} has been deleted, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                await logChannel.SendMessage($"Warning, {e.Role.Name} has been deleted, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));

        }

        public async void _client_RoleUpdated(object sender, RoleUpdatedEventArgs e)
        {

                //Permissions, before and after. (1 and 2)
                string adminPerm = e.Before.Permissions.Administrator ? "Yes" : "No";
                string banPerm = e.Before.Permissions.BanMembers ? "Yes" : "No";
                string kickPerm = e.Before.Permissions.KickMembers ? "Yes" : "No";
                string changeNickNamePerm = e.Before.Permissions.ChangeNickname ? "Yes" : "No";
                string createInstantInvitePerm = e.Before.Permissions.CreateInstantInvite ? "Yes" : "No";
                string manageChannelsPerm = e.Before.Permissions.ManageChannels ? "Yes" : "No";
                string manageMsgsPerm = e.Before.Permissions.ManageMessages ? "Yes" : "No";
                string manageNicknamesPerm = e.Before.Permissions.ManageNicknames ? "Yes" : "No";
                string manageRolesPerm = e.Before.Permissions.ManageRoles ? "Yes" : "No";
                string moveMembersPerm = e.Before.Permissions.MoveMembers ? "Yes" : "No";

                string adminPerm2 = e.After.Permissions.Administrator ? "Yes" : "No";
                string banPerm2 = e.After.Permissions.BanMembers ? "Yes" : "No";
                string kickPerm2 = e.After.Permissions.KickMembers ? "Yes" : "No";
                string changeNickNamePerm2 = e.After.Permissions.ChangeNickname ? "Yes" : "No";
                string createInstantInvitePerm2 = e.After.Permissions.CreateInstantInvite ? "Yes" : "No";
                string manageChannelsPerm2 = e.After.Permissions.ManageChannels ? "Yes" : "No";
                string manageMsgsPerm2 = e.After.Permissions.ManageMessages ? "Yes" : "No";
                string manageNicknamesPerm2 = e.After.Permissions.ManageNicknames ? "Yes" : "No";
                string manageRolesPerm2 = e.After.Permissions.ManageRoles ? "Yes" : "No";
                string moveMembersPerm2 = e.After.Permissions.MoveMembers ? "Yes" : "No";



                var rithari = e.Server.GetUser(127504308156628992);

                if(e.Before.Permissions.RawValue != e.After.Permissions.RawValue)
                {

                    await rithari.SendMessage($"Warning, {e.Before.Name} has been modified, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));
                    await rithari.SendMessage("```fix\n" + "Server: " + e.Server.Name + "\n" + e.Before.Name + "'s Permissions: " + "\nIs Admin: " + adminPerm + "\nCan Ban Members: " + banPerm + "\nCan Kick Members: " + kickPerm + "\nCan Change Nickname: " + changeNickNamePerm + "\nCan Create Instant Invites: " + createInstantInvitePerm + "\nCan Manage Channels: " + manageChannelsPerm + "\nCan Manage Messages: " + manageMsgsPerm + "\nCan Manage Nicknames: " + manageNicknamesPerm + "\nCan Manage Roles: " + manageRolesPerm + "\nCan Move Members: " + moveMembersPerm + "```");
                    await rithari.SendMessage("```fix\n" + "Server: " + e.Server.Name + "\n" + e.After.Name + "'s Permissions: " + "\nIs Admin: " + adminPerm2 + "\nCan Ban Members: " + banPerm2 + "\nCan Kick Members: " + kickPerm2 + "\nCan Change Nickname: " + changeNickNamePerm2 + "\nCan Create Instant Invites: " + createInstantInvitePerm2 + "\nCan Manage Channels: " + manageChannelsPerm2 + "\nCan Manage Messages: " + manageMsgsPerm2 + "\nCan Manage Nicknames: " + manageNicknamesPerm2 + "\nCan Manage Roles: " + manageRolesPerm2 + "\nCan Move Members: " + moveMembersPerm2 + "```");

                    var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                await logChannel.SendTTSMessage($"Warning: {e.Before.Name} has been modified, was this intentional?" + "\n" + DateTime.Now.ToString("HH:mm:ss"));

                }
                else
                {
                    return;
                }

           
        }


        public async void _client_UserBanned(object sender, UserEventArgs e)
        {


                // Create a Channel object by searching for a channel named '#logs' on the server the ban occurred in.
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                // Send a message to the server's log channel, stating that a user was banned.
                await logChannel.SendTTSMessage($"{e.User.Name} has been permanently banned.\n" + DateTime.Now.ToString("HH:mm:ss"));

        }

        public async void _client_UserUnbanned(object sender, UserEventArgs e)
        {

                // Create a Channel object by searching for a channel named '#logs' on the server the ban occurred in.
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                // Send a message to the server's log channel, stating that a user was unbanned.
                await logChannel.SendMessage($"{e.User.Name} has been unbanned." + "\n" + DateTime.Now.ToString("HH:mm:ss"));

        }
        public static async void _client_MessageDeleted(object sender, MessageEventArgs e)
        {
            try
            {
                string log = "Deleted message from [" + e.User.Name + "] on server [" + e.Server.Name + "] in channel [" + e.Channel.Name + "]: " + e.Message.Text;
                Console.WriteLine(log);
                File.AppendAllText("logs.txt", string.Join("\n", File.ReadAllLines("logs.txt").Distinct().ToArray()) + log + @"");

                    if (e.User.Id == 127504308156628992 || e.Message.IsAuthor)
                    {
                        return;;
                    }
                    var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                    if (logChannel == null)
                        return;
                    // Send a message to the server's log channel, stating that a user has deleted their message.
                    await logChannel.SendMessage($"{e.User.Name}'s message has been deleted " + "\n" + DateTime.Now.ToString("HH:mm:ss") + "\n\n\n" + log);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine(@"Deleted message which returned a NullRefEx.");
            }
        }

        public static async void _client_MessageEdited(object sender, MessageUpdatedEventArgs e)
        {
            if (e.User.Name == null || e.After == null || e.Before == null)
            {
                Console.WriteLine("Edited message nullrefex.");
                return;
            }
            if (e.Before.Text != e.After.Text)
            {
                string log = "Edited message from [" + e.User.Name + "] on server [" + e.Server.Name + "] in channel [" + e.Channel.Name + "]: (BEFORE) " + e.Before;
                string log2 = "Edited message from [" + e.User.Name + "] on server [" + e.Server.Name + "] in channel [" + e.Channel.Name + "]: (AFTER) " + e.After;
                Console.WriteLine(log);
                Console.WriteLine(log2);
                File.AppendAllText("logs.txt", string.Join("\n", File.ReadAllLines("logs.txt").Distinct().ToArray()) + log + @"");
                File.AppendAllText("logs.txt", string.Join("\n", File.ReadAllLines("logs.txt").Distinct().ToArray()) + log2 + @"");


                    if (e.User.Id == 127504308156628992 || e.Before.IsAuthor)
                    {
                        return;
                    }
                    var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                    if (logChannel != null)
                    {
                        // Send a message to the server's log channel, stating that a user has edited their message.
                        await logChannel.SendMessage($"{e.User.Name}'s message has been edited." + "\n" + DateTime.Now.ToString("HH:mm:ss") + "\n\n\n" + log + "\n" + log2);
                    }
            }

        }

        public static async void _client_UserJoined(object sender, UserEventArgs e)
        {

                var memberrole = new List<string> { "Member" };
                var addtomember = e.Server.Roles.Where(x => memberrole.Contains(x.Name.ToLower())).ToArray();

            if (e.Server.Id == 545646546545)
            {
                await e.User.AddRoles(addtomember);
            }

                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                // Send a message to the server's log channel, stating that a user has joined the server.
                await logChannel.SendMessage($"{e.User.Name} has entered the server." + "\n" + DateTime.Now.ToString("HH:mm:ss"));
        }

        public static async void _client_UserLeft(object sender, UserEventArgs e)
        {
          
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                // Send a message to the server's log channel, stating that a user has left the server.
                await logChannel.SendMessage($"{e.User.Name} has left the server." + "\n" + DateTime.Now.ToString("HH:mm:ss"));
        }

        public static async void _client_ChannelUpdated(object sender, ChannelUpdatedEventArgs e)
        {
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                if (e.Before.Topic != e.After.Topic)
                {
                    await logChannel.SendMessage($"{e.Before.Topic} was the previous channel topic.");
                    await logChannel.SendMessage($"{e.After.Topic} is the current channel topic.");
                }

                if (e.Before.Name != e.After.Name)
                {
                    await logChannel.SendMessage($"{e.Before.Name} was the previous channel name.");
                    await logChannel.SendMessage($"{e.After.Name} is the current channel name.");
                }
                if (e.Before.IsPrivate != e.After.IsPrivate)
                {
                    await logChannel.SendMessage($"{e.Before.IsPrivate} was the previous IsPrivate value.");
                    await logChannel.SendMessage($"{e.After.IsPrivate} is the current IsPrivate value.");
                }
            }

        public static async  void _client_ChannelCreated(object sender, ChannelEventArgs e)
        {
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;

                await logChannel.SendMessage($"{e.Channel.Mention} has been created");
                if (e.Channel.IsPrivate)
                {
                    await logChannel.SendMessage($"{e.Channel.Name} is a private channel.");
                }
                await logChannel.SendMessage($"'{e.Channel.Type}' is the channel type. ");
                if (e.Channel.Topic == string.Empty)
                {
                    await logChannel.SendMessage($"The channel is topic-less.");
                }
                else
                await logChannel.SendMessage($"'{e.Channel.Topic}' is the channel topic.");
        }

        public static async void _client_ChannelDestroyed(object sender, ChannelEventArgs e)
        {

            
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                if (e.Channel.Name == "deleted-channel")
                {
                    await logChannel.SendMessage($"Not identifiable channel was deleted, channel id: {e.Channel.Id}");
                }
                await logChannel.SendMessage($"{e.Channel.Name} was deleted.");

        }

        public static void _client_UserUpdated(object sender, UserUpdatedEventArgs e)
        {
                var logChannel = e.Server.FindChannels("logs").FirstOrDefault();
                if (logChannel == null)
                    return;
                if (e.Before.IsSelfDeafened != e.After.IsSelfDeafened)
                {
                    logChannel.SendMessage($"{e.After.IsSelfDeafened} is the current value of IsSelfDeafened.");
                }


                if (e.Before.IsServerMuted != e.After.IsServerMuted)
                {
                    logChannel.SendMessage($"{e.After.IsServerMuted} is the current value of IsServerMuted.");
                }


                if (e.Before.IsServerDeafened != e.After.IsServerDeafened)
                {
                    logChannel.SendMessage($"{e.After.IsServerDeafened} is the current value of IsServerDeafened.");
                }


                if (e.Before.IsSelfMuted != e.After.IsSelfMuted)
                {
                    logChannel.SendMessage($"{e.After.IsSelfMuted} is the current value of IsSelfMuted.");
                }


                if (e.Before.IsServerSuppressed != e.After.IsServerSuppressed)
                {
                    logChannel.SendMessage($"{e.After.IsServerSuppressed} is the current value of IsServerSuppressed.");
                }


                if (e.Before.AvatarUrl != e.After.AvatarUrl)
                {
                    logChannel.SendMessage($"{e.After.AvatarUrl} is the user's new avatar url.");
                }


                if (e.Before.Nickname != e.After.Nickname)
                {
                    logChannel.SendMessage($"{e.After.Nickname} is the user's new nickname.");
                }
        }

        public static void _client_ProfileUpdated(object sender, ProfileUpdatedEventArgs e)
        {

        }

        public static void _client_MessageReceived(object sender, MessageEventArgs e)
        {
            if (Regex.IsMatch(e.Message.Text, @"\!\w+") || Regex.IsMatch(e.Message.Text, @"\!\w+") && Client.Status == UserStatus.Idle)
            {
                Client.SetStatus(UserStatus.Online);
                DummyTimer.Dispose();

                DummyTimer = new System.Threading.Timer(cb =>
                {
                    Client.SetStatus(UserStatus.Idle);
                }, null, TimeSpan.FromSeconds(600), TimeSpan.FromSeconds(600));
            }
            Log(e);
        }


        public static void Log(MessageEventArgs e)
        {
            var urlEncode = WebUtility.UrlEncode(e.Channel.Name);
            if (urlEncode != null)
            {
                string fixedchannel = urlEncode;

              //  if (e.Server != null)
                 //   File.AppendAllText("logs/" + e.Server.Name + "-" + fixedchannel + ".txt", @"[" + (DateTime.Now.ToString("HH:mm") + " ") + e.User.Name + @"]: " + e.Message.Text + @"");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Disconnect();
                listingbutton.Enabled = false;
                botsettingsbutton.Enabled = false;
                botsettingsbutton.ForeColor = Color.DarkRed;
                listingbutton.ForeColor = Color.DarkRed;
                userscount.ForeColor = Color.DarkRed;
                channelcount.ForeColor = Color.DarkRed;
                servercount.ForeColor = Color.DarkRed;
                userscount.Text = "Users: " + "Offline";
                channelcount.Text = "Channels: " + "Offline";
                servercount.Text = "Servers: " + "Offline";
                DummyTimer.Dispose();
                DummyTimer2.Dispose();
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionnumber.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
            backgroundWorker1.RunWorkerAsync();
            listingbutton.ForeColor = Color.DarkRed;
            userscount.ForeColor = Color.DarkRed;
            channelcount.ForeColor = Color.DarkRed;
            servercount.ForeColor = Color.DarkRed;
            userscount.Text = "Users: " + "Offline";
            channelcount.Text = "Channels: " + "Offline";
            servercount.Text = "Servers: " + "Offline";
            Writer = new TextBoxStreamWriter(console); //status = the TextBox element
            Console.SetOut(Writer);
            Console.WriteLine("Created by Rithari.\nC# Discord bot with integrated auto update.\n");
          //  Console.WriteLine(
            //    "░░░░░░░░░░░░░░░░░▄▄▄▄▄▄\r\n░░░░░░░░░░░░░▄▄▀▀░░░░░░▀▄\r\n░░░░░░░░░░░▄▀░░░░░░░░░░▄▄▌░▄██▀▄\r\n░░░░░░░▀▄▄▀░░░░░░░░░░░░▄▄███▀▀▌▐\r\n░░░░░░▐▄▀███▄░░▄█▄▄░░▄▀▒▒▒▒▀▀▄▐░▌\r\n░░░░░▄▌▀▄▐▀▒▀▄▀▀▒▒▒▀▀▄▀▄▒▒▒▒▒▒▀▄▌▀\r\n░░░░▐░▌▐▄▌▒▒▒▄▀▀▄▒▒▒▐▄▒▒▒▒▒▒▒▒▒▒▐▀\r\n░░░░▐▄▐▐▒▒▒▒▒▒▒▐░▌▒▒▒▌▀▄▀▀▄▒▒▒▒▒▒▌\r\n░░░░▐▄▄▌▒▒▒▌▒▄▀▀▄▀▄▒▒▌▌░░░▐▄▒▒▒▒▒▐\r\n░░░░▐▌▒▒▒▒▐▒▄▀░░░█░▀▄▐░▌░░▐█▐▒▒▀▄▐\r\n░░░░░▌▒▒▒▒▐▀▄░░░▄█░░░▀▐▄▄███░▌▒▐▐▐\r\n░░░░▐▒▒▒▒▒▌░█▄▄███▌░░░▐████▀▌▐▒▒▌▀\r\n░░░░▐▒▒▒▒▒▌░████▌█▌░░░░█▀█▀░▌▐▒▒▐\r\n░░░░▐█▒▒▒▒▌░▐░▀▀░▐░░░▀░░▀░░░░░▀▌▐\r\n░░░░▐█▌▒▒▒▐░░░░░░▐▄▄▀▄▀░░░░░░░▄▀▌\r\n▄▀▄░░██▄▒▒▒▌░░░░░░▐▄▀░░░░░░░▄▀▒█\r\n▀▄▐▌░▐█▀▄▒▒▀▄░▄▄▄▄░░░▄▄▀▀▀██▒▒█\r\n░▐██░░██░▀▄▐░▀▌░░░▀█▀▌░░░▐▀▐▄▀\r\n░░██▌▐█▌░▐░▀▀▌▌░░▄░▌░▌▄░░▌▐﻿     HoNk HoNk MoThErFuCkEr :o)﻿\r\n");
            tokenbox.Text = File.Exists("cache.txt") ? File.ReadAllText("cache.txt") : "";
            remembercheckbox.Checked = File.Exists("cache.txt") ? true : false;
            listingbutton.Enabled = false;
            botsettingsbutton.Enabled = false;

        }

        private void decryptbtn_Click(object sender, EventArgs e)
        {
            if (texttodecrypt.Text == string.Empty)
            {
                Console.WriteLine(@"Please enter a string to decrypt.");
            }
            if (pwdecrypt.Text == string.Empty)
            {
                Console.WriteLine(@"Enter the password used for encryption, a wrong password will probably result in a program failure.");
                return;
            }
            var toReturn = StringCipher.Decrypt(texttodecrypt.Text, pwdecrypt.Text);
            texttodecrypt.Text = toReturn;
        }

        private void encryptbtn_Click(object sender, EventArgs e)
        {
            if (texttoencrypt.Text == string.Empty)
            {
                Console.WriteLine(@"Please enter a string to encrypt.");
                return;
            }
            if (pwencrypt.Text == string.Empty)
            {
                Console.WriteLine(@"Enter a password in order to protect your encrypted string from unauthorized decrypting.");
                return;
            }
            var toReturn = StringCipher.Encrypt(texttoencrypt.Text, pwencrypt.Text);
           texttoencrypt.Text = toReturn;
        }

        private void listingbutton_Click(object sender, EventArgs e)
        {
            Listing form = new Listing();
            form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "ENCRYPTION\n\n1)Enter a string to encrypt.\n2)Enter a password to secure your encryption.\n3)Click on the encrypt button and store the encrypted string along with the password somewhere safe.\n\n\nDECRYPTION\n\n1)Enter an encrypted string.\n2)Enter the password you have safely stored during the encryption progress.\n3Click on the decrypt button and enjoy your string as if it was never encrypted :O!\n\n\nAlgorithm coded by Rithari.","Tutorial");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            updater.DoUpdate();
            //  var simpleSound = new SoundPlayer(@"honk.wav");
            // simpleSound.Play();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void botsettingsbutton_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        public string ApplicationName
        {
            get { return "DiscordBot2"; }
        }

        public string ApplicationID
        {
            get { return "DiscordBot2"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://www.associazioneculturalearsnova.com/sharpupdatelib/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
            
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
