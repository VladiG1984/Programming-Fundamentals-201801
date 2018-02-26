using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var carRegistry = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                string action = command[0];
                string user = command[1];
                
                if (action == "register")
                {
                    string licensePlate = command[2];

                    bool isPlateValid = CheckPlateValid(licensePlate);

                    if (carRegistry.ContainsKey(user))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", carRegistry[user]);
                        continue;
                    }

                    if (!isPlateValid)
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", licensePlate);
                        continue;
                    }

                    if (carRegistry.ContainsValue(licensePlate))
                    {
                        Console.WriteLine("ERROR: license plate {0} is busy", licensePlate);
                        continue;
                    }

                    carRegistry.Add(user, licensePlate);
                    Console.WriteLine("{0} registered {1} successfully", user, licensePlate);
                }

                else if (action == "unregister")
                {
                    if (!carRegistry.ContainsKey(user))
                    {
                        Console.WriteLine("ERROR: user {0} not found", user);
                        continue;
                    }
                    
                    carRegistry.Remove(user);
                    Console.WriteLine("user {0} unregistered successfully", user);
                }

            }

            // print all registered users and their license plates
            foreach (var user in carRegistry)
            {
                Console.WriteLine("{0} => {1}", user.Key, user.Value);
            }
        }

        static bool CheckPlateValid(string licensePlate)
        {
            int licensePlateLength = licensePlate.Length;

            if (licensePlateLength != 8)
            {
                return false;
            }

            string firstTwoLetters = licensePlate.Substring(0, 2);
            string lastTwoLetters = licensePlate.Substring(6, 2);
            string plate4digits = licensePlate.Substring(2, 4);

            if (!CheckLettersAreNotDigits(firstTwoLetters))
            {
                return false;
            }

            if (!CheckLettersAreNotDigits(lastTwoLetters))
            {
                return false;
            }

            if (!CheckLettersAreUpperCase(firstTwoLetters))
            {
                return false;
            }

            if (!CheckLettersAreUpperCase(lastTwoLetters))
            {
                return false;
            }

            try
            {
                int plateDigits = int.Parse(plate4digits);
            }
            catch
            {
                return false;
            }

            return true;
        }

        static bool CheckLettersAreUpperCase(string twoLetters)
        {
            string twoLettersUpperCase = twoLetters.ToUpper();

            if (twoLetters.Equals(twoLettersUpperCase))
            {
                return true;
            }

            return false;
        }

        static bool CheckLettersAreNotDigits(string twoLetters)
        {
            for (int i = 0; i < 2; i++)
            {
                if (twoLetters[i] < 'A' || twoLetters[i] > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        // Below is also a possible solution (but not mine):
        //static bool CheckPlateValid(string plate)
        //{
        //    if (plate.Length != 8)
        //    {
        //        return true;
        //    }
        //    var firstLastTwoSymbols = plate.Substring(0, 2) + plate.Substring(6);
        //    foreach (var symbol in firstLastTwoSymbols)
        //    {
        //        if (symbol < 'A' || 'Z' < symbol)
        //        {
        //            return true;
        //        }
        //    }
        //    var midleSymbols = plate.Substring(2, 4);
        //    foreach (var symbol in midleSymbols)
        //    {
        //        if (symbol < '0' || '9' < symbol)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
