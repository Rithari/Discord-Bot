# Rithari's Discord Bot
Written in C# wit the Discord.NET library to bring a unique experience by adding some cryptography and an auto update system to common bot features. 

This bot is **WORK IN PROGRESS**.

Currently, It's just me who works on this bot, but thanks to others more features were able to be included in this project. They are credited at the end of this readme.

Some of the features here are still broken and some are still in development, the sole purposes this repository serves is to give others the opportunity of contributing and learning.

##Features & Commands##
* Logging, this bot logs every single message in a separate folder stored in the local directory in a form of .txt, there is one file for each different channel there is. There is also more intensive logging, such as edited messages, deleted one, banned users, unbanned, role assigned... basically it logs everything there is to log in a separate channel (#logs, which can be created by the bot user);
    
* 256bit AES Cryptography, this bot comes with a full encryption algorithm which allows 256bit AES encryption with any type of string and even images;

* 30+ Commands, these include 'ping', 'summon' 'getperms' 'memgen' and more, which will be explained later on;

* Full customizability, through the bot you can tweak almost everything one would want to tweak in a bot;

* Automatic Game Changing System (AGCS), this system makes sure that the bot switches between a preset list of games automatically, this can be turned off in the bot settings;

* Musicbot functionality, you can make the bot play any of the over 500 built-in songs, though those are reproduced randomly;

* Auto Update System (AUS), this system makes sure you're always up to date with your bot, manually updating is yesteday;

* Mention-Prefix, sick of always having to write ! before your command? You can also mention your bot followed by a command to make it do things. (e.g. @BotName ping);

* !ping, this command is among the simplest commands there are in the bot, it returns a string, usually used to check whether the bot died or not;

* !summon, the command used to summon the bot to a voice channel, which has to be created by the bot user. The voicechannel name should be 'Music', it will then automatically play a song;

* !unsummon, the command used to unsummon the bot from a voice channel, thus stopping to play music;

* !doesntwork, a remade version of the !doesntwork command from the Discord API Server;

* !errors, same as !doesntwork;

* !clear 'parameter', this command, followed by a number will delete the amount of messages specified in the numeric parameter. (!clear 5 would delete the last 5 messages.);

* !echo 'parameter', this command, followed by a string parameter will make the bot output your parameter. (!echo hello will make the bot say hello);

* !getperms @UserMention or UserName, is used to grab a user's permissions to check whether the user is able to do certain actions;


* !myperms, the same as !getperms, just for yourself;

* !setgame 'parameter', will set the bot's current game to the specified parameter. (!setgame Garry's Mod will make the bot say it's playing Garry's Mod);

* !shutdown, this command will make the bot shutdown, this can be done just by me right now, but will soon be available to who uses the bot as well (Will be an option in the settings);

* !google 'parameter' will make the google searching easier for you;

* !lmgtfy 'parameter' same thing as !google, just for let me google that for you;

* !bool 'parameter', currently only usable by me, it changes a boolean in the code;

* !encrypt 'parameter' encrypts your parameter, and outputs the encrypted string;

* !decrypt 'decryptedstring' will decrypt what you have encrypted, if you are wondering when you get to choose a password for the encryption, I've decided to do that part on its own, instead of making the user specify a password for it to encrypt and decrypt, you can specify one in the bot application though;.

* !imgencrypt 'link to an image' will turn your image into a byte array and encrpyt it, after that it will send you a .bin file containing the encrypted image;

* !imgdecrypt 'link to the encrypted .bin file' will decrypt an image which was previously encrypted, same here, password part done in the code;

* !8ball 'parameter', parameter equals to a question, the bot will reply with a random answer (Yes, No, Maybe...);

* !roulette, russian roulette;

* !yt 'parameter' will output the first video found according to your search terms (parameter);

* !define 'parameter' parameter equals a word which you want to know the meaning of, will browse urban dictionary for that;

* !quote @usermention 'paramater', parameter equals to the message the mentioned user apparently said, a useless command but I added it out of fun, to be removed;

* !lovecalc 'person1' and 'person 2', will calculate the % of love between two targets, can also be used like this: !lovecalc p, p instead of p and p;

* !code, will convert a pasted c# code into a formatted c# highlighted code block;

* !ban, supposed to ban an user, doesn't work, use the one in the server browser to ban people;

* !unban also doesn't work yet;

* !joke, outputs the biggest joke there is, it's a person which has reached the limits of negative IQ;

* !timer 'x seconds|minutes|hours' 'parameter' Will set a timer for you and remind you when it expires, for instance !timer 10 seconds fap will remind you to fap in 10 seconds;

* !color, will add a role to you, which will change your username color, only works if set up properly by bot owner on a server;

* !uncolor, removes all color from a user;

* !mute 'username' or @mention, will remove all roles from a user and add a muted role, which once set up by the server owner, will stop the muted user from doing anything;

* !unmute, undoes !mute, doesn't restore previous roles though;

* !steamp 'username', will give you a neat little banner for the specified user as seen below;

* !mal {anime/manga} 'name', is sadly broken, but is supposed to output you a manga or anime you were searching for;

* !memegen 'phrase 1, phrase2 {linktoimage}', this will add a meme to any image you link it, as seen below.
    
    
    
##Credits#
Some of the features were made possible thanks to other programmers which include:
* BetterCoder - Thank you for helping with the auto update library.
* The Discord API Server - Without it, a lot of things which I would never have noticed otherwise were noticed, help was given and so was advice. A great spot if you're having some trouble with the API.
* xplatinumx - Thank you for some of the features and helping me out with the initial design of the form. Inspired me to do my own winforms discord bot.
* Everyone - Thanks to all of the people that have followed this bot's development for their moral support.

