using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Discord;

/// <summary>
/// BeakoBotNew
/// </summary>
namespace BeakoBotNew
{
    /// <summary>
    /// My extensions for discord
    /// </summary>
    public static class beakoExtensions
    {
        /// <summary>
        /// Convert string to user
        /// </summary>
        /// <param name="nameInput"></param>
        /// <param name="userList"></param>
        /// <returns>The user object of the target</returns>
        public static User ToUser(this string nameInput, IEnumerable<User> userList)
        {
            ///<seealso cref="User"/>
            ///<exception cref="Exception">
            ///User object not found in userList
            ///</exception>

            //Cache the string while splitting any @ symbols if it has any
            string name = nameInput.Contains("@") ? Regex.Split(nameInput, @"\@")[1] : nameInput;

            try //Try and pull a single value out of the list of users
            {
                //Return the user object by their name
                return userList.Single(x => x.Name == name);
            }
            catch(Exception) //If it fails to match, catch the exception and return null
            {
                return null; //Return null for easy error handling
            }
        }

        /// <summary>
        /// Convert string to channel
        /// </summary>
        /// <param name="channelName"></param>
        /// <param name="channelList"></param>
        /// <returns>The channel object</returns>
        public static Channel ToChannel(this string channelName, IEnumerable<Channel> channelList)
        {
            ///<seealso cref="Channel"/>
            ///<exception cref="Exception">
            ///Channel object not found in channelList
            ///</exception>

            //Split past any @ or # symbols in the string to get the name
            string name = Regex.IsMatch(channelName, @"\#|\@") ? Regex.Split(channelName, @"\#|\@")[1] : channelName;

            try //Try and pull a single value out of the list
            {
                //Return the channel object here
                return channelList.Single(x => x.Name == channelName);
            }
            catch(Exception) //If none matches, catch the exception and return it as null
            {
                return null; //Return as null for easy error handling
            }
        }

        /// <summary>
        /// Convert string to server
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="serverList"></param>
        /// <returns>The server object</returns>
        public static Server ToServer(this string serverName, IEnumerable<Server> serverList)
        {
            ///<seealso cref="Server"/>
            ///<exception cref="Exception">
            ///Server object not found in serverList
            ///</exception>

            //Split past any @ symbols if there are any that were in the string passed into as a parameter
            string servername = serverName.Contains("@") ? Regex.Split(serverName, @"\@")[1] : serverName;

            try //Try and pull a single value out of the server list
            {
                //Return the server object 
                return serverList.Single(x => x.Name == servername);
            }
            catch(Exception) //If it fails to match, return null
            {
                return null; //Return null for easy error handling
            }
        }

        /// <summary>
        /// Returns a set of users
        /// Based on predical prediction
        /// </summary>
        /// <param name="userList"></param>
        /// <param name="predicate"></param>
        /// <returns>IEnumerable set of users</returns>
        public static IEnumerable<User> ReturnUsersWith(this IEnumerable<User> userList, Predicate<User> predicate)
        {
            ///<exception cref="NullReferenceException">
            ///Happens when the Predicate is null
            ///</exception>
            ///<exception cref="Exception">
            ///Happens when TakeWhile returns nothing
            ///</exception>
            ///<seealso cref="IEnumerable{User}"/>

            try //Try and take values out of them
            {
                //Return the IEnumerable object of users
                return userList.Where(x => predicate.Invoke(x));
            }
            catch(Exception) //Catch any errors and return null for error handling
            {
                return null; //Return null for error handling
            }
        }
    }
}
