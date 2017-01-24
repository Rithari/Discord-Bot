using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Discord;

namespace DiscordBot2
{
   public static class Extensions
    {
        public static Server ToServer(this string input, IEnumerable<Server> serverlist)
        {
            return serverlist.Single(x => { return input != null && x.Name == input; });
        }

        public static Channel ToChannel(this string input, IEnumerable<Channel> channellist)
        {
            return channellist.Single(x => x.Name == input);
        }

       public static User ToUser(this string input, IEnumerable<User> userlist)
       {
           return userlist.Single(x => x.Name == (input.Contains("@") ? Regex.Split(input, @"\@")[1] : input));
       }
    }
}
