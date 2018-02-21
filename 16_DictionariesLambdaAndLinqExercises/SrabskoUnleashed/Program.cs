using System;
using System.Linq;
using System.Collections.Generic;

namespace SrabskoUnleashed
{
    class Program
    {
        static bool CheckIfInputIsValid(string[] input)
        {
            bool isValidVenue = false;
            int indexOfVenue = 0;

            for (int word = 0; word < input.Length; word++)
            {

                if (input[word].StartsWith("@"))
                {
                    isValidVenue = true;
                    indexOfVenue = word;
                    break;
                }
            }
            
            if (!isValidVenue)
            {
                return false;
            }

            // if venue is at the beginning of a word, now check if:
            // a) singer has no less than one word and no more than three
            // b) there are exactly two words (numbers) behind venue

            // check singer is between one and three words
            if (indexOfVenue > 3 || indexOfVenue < 1)
            {
                return false;
            }

            // check there are two words (numbers) behind venue given that venue may be between one and three
            // words
            if (indexOfVenue > input.Length - 3 || indexOfVenue < input.Length - 5)
            {
                return false;
            }

            try
            {
                int.Parse(input[input.Length - 2]);
                int.Parse(input[input.Length - 1]);
            }
            catch
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            IDictionary<string, IDictionary<string, int>> venueAndSingerDict =
                new Dictionary<string, IDictionary<string, int>>();

            while (true)
            {
                // read input from console and remove any blanks/ whitespaces
                string[] input = Console.ReadLine()
                        .Split(' ')
                        .Where(w => w != "")
                        .ToArray();

                // stop program if input is End
                if (input[0].Equals("End"))
                {
                    break;
                }

                // skip invalid input
                bool inputIsValid = CheckIfInputIsValid(input);
                if (!inputIsValid)
                {
                    continue;
                }

                // if input is valid, assign it to input variables
                // assign singer
                List<string> currentSinger = new List<string>();
                int currentMember = 0;
                while(!input[currentMember].StartsWith("@"))
                {
                    currentSinger.Add(input[currentMember]);
                    currentMember++;
                }
                string singer = String.Join(" ", currentSinger);

                // assign venue
                //currentMember = 0;
                int number = 0;
                List<string> currentVenue = new List<string>();
                while(!int.TryParse(input[currentMember], out number))
                {
                    currentVenue.Add(input[currentMember]);
                    currentMember++;
                }
                string venue = String.Join(" ", currentVenue).Remove(0, 1);

                // assign values to ticket price and ticket count
                int ticketPrice = int.Parse(input[currentMember]);
                int ticketCount = int.Parse(input[currentMember + 1]);

                //Console.WriteLine("singer: " + singer);
                //Console.WriteLine("venue: " + venue);
                //Console.WriteLine("ticket price: " + ticketPrice + ", ticket count: " + ticketCount);

                // fill the dictionary whose key is venue and value is a dictionary with key singer and value
                // revenue = ticket price * ticket count
                if (!venueAndSingerDict.ContainsKey(venue))
                {
                    venueAndSingerDict.Add(venue, new Dictionary<string, int>());
                }

                if (!venueAndSingerDict[venue].ContainsKey(singer))
                {
                    venueAndSingerDict[venue].Add(singer, ticketPrice * ticketCount);
                }
                else
                {
                    venueAndSingerDict[venue][singer] += (ticketPrice * ticketCount);
                }
            }

            foreach (KeyValuePair<string, IDictionary<string, int>> pair in venueAndSingerDict)
            {
                Console.WriteLine(pair.Key);

                foreach(KeyValuePair<string, int> artist in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", artist.Key, artist.Value);
                }
            }

        }
    }
}
