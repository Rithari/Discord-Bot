using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot2
{
        public static class MemeGeneratorExtention
        {
            public static string InsertNewLineAfterEvery(this string input, int Placement)
            {
                ///<summary>
                ///inserts a newline after every
                ///certain amount of characters and returns
                ///the input
                ///</summary>

                int currentIndex = 0; //The current index

                //Create a new list to store the new values in 
                List<string> Returnable = new List<string>();

                //Loop through all the characters
                input.Select(x => x.ToString()).ToList().ForEach(x =>
                {
                    //if its at a multiple of 18th's index
                    if (currentIndex % Placement == 0 && Returnable.Count != 0)
                    {
                        Returnable.Add(x + "\r\n");
                    }
                    else
                    {
                        Returnable.Add(x);
                    }
                    currentIndex += 1;
                });

                //Check if the concat screwed up
                if (Returnable.Last() == "-")
                {
                    Returnable.Remove(Returnable.Last());
                }

                return string.Concat(Returnable.ToArray());
            }
        }
    }
