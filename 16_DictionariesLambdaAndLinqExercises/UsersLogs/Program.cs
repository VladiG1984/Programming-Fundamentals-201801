using System;
using System.Linq;
using System.Collections.Generic;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a sorted dictionary to contain data in alphabetic order for usernames and data for each 
            // username in chronological order about his/ her IP address and number of messages sent via this
            // address
            IDictionary<string, IDictionary<string, int>> userLogList =
                        new SortedDictionary<string, IDictionary<string, int>>();

            while (true)
            {
                // use command (array) to split input from the console into parts (unless input = end):
                // first part is the IP address, second is the messages (not to be used), third - username;
                string[] command = Console.ReadLine()
                        .Replace("IP=", "")
                        .Replace("message=", "")
                        .Replace("user=", "")
                        .Split(' ')
                        .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                string username = command[2];
                string addressIP = command[0];

                // check if user already exist in sorted dictionary
                // if present, check if user's IP address already exist in the dictionary within the sorted dict
                // if it is present too, increment the count of same IP occurrences
                // else if address is not present, create new address entry in dictionary and start count at 1
                // else if both user and address missing from dictionary, create user entry and fill in
                // dictionary address and count at 1
                if (userLogList.ContainsKey(username))
                {
                    if (userLogList[username].ContainsKey(addressIP))
                    {
                        userLogList[username][addressIP]++;
                    }
                    else
                    {
                        userLogList[username].Add(addressIP, 1);
                    }
                }
                else
                {
                    IDictionary<string, int> addressIpBook = new Dictionary<string, int>
                    {
                        { addressIP, 1 }
                    };

                    userLogList.Add(username, addressIpBook);
                }
            }

            // print to the console as per requested format
            foreach (KeyValuePair<string, IDictionary<string,int>> item in userLogList)
            {
                // print user's name
                Console.WriteLine(item.Key + ":");

                // create array to keep address and its count for each user (helps with printing in requred format
                // Note: here creating a list instead of an array would take too much processing time when
                // tested in SoftUni's Judge
                string[] addressBook = new string[item.Value.Count];
                int count = 0;

                foreach (KeyValuePair<string, int> element in item.Value)
                {
                    string address = element.Key + " => " + element.Value;
                    addressBook[count] = address;
                    count++;
                }
                // print user's addresses and counts
                Console.WriteLine(String.Join(", ", addressBook) + ".");
            }
        }
    }
}
