using System;
using System.Linq;
using System.Collections.Generic;

namespace FixedEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> emailList = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name.Equals("stop"))
                {
                    break;
                }

                string email = Console.ReadLine();

                emailList.Add(name, email);

                if (email.Contains(".us") || email.Contains(".uk"))
                {
                    emailList.Remove(name);
                }
            }

            foreach (KeyValuePair<string, string> item in emailList)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
