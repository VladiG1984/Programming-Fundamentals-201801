using System;
using System.Linq;
using System.Collections.Generic;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictinary in which to embed sorted dictionary and in the sorted dictionary to input
            // a list
            IDictionary<string, SortedDictionary<string, List<int>>> dragonsDict = 
                    new Dictionary<string, SortedDictionary<string, List<int>>>();

            // enter number of dragons
            int numberOfDragons = int.Parse(Console.ReadLine());

            // investigate each dragon and put it in the dictionary(ies):
            // a) his type is the key of the main dictionary
            // b) his name is the key of the embedded sorted dictionary
            // c) his parameters: damage, health, armor are the elements of the embedded list
            for (int currentDragon = 0; currentDragon < numberOfDragons; currentDragon++)
            {
                string[] dragon = Console.ReadLine().Split(' ').ToArray();

                string type = dragon[0];
                string name = dragon[1];

                // in case of null present for any dragon's parameter, enter a default value
                int damage = 45;
                //int.TryParse(dragon[2], out damage);
                if (dragon[2] != "null")
                {
                    damage = int.Parse(dragon[2]);
                }

                int health = 250;
                if (dragon[3] != "null")
                {
                    health = int.Parse(dragon[3]);
                }
                int armor = 10;
                if (dragon[4] != "null")
                {
                    armor = int.Parse(dragon[4]);
                }

                // enter dragons characteristics into the dictionary
                if (!dragonsDict.ContainsKey(type))
                {
                    dragonsDict.Add(type, new SortedDictionary<string, List<int>>());
                }

                if (!dragonsDict[type].ContainsKey(name))
                {
                    dragonsDict[type].Add(name, new List<int>());
                }
                
                dragonsDict[type][name] = new List<int> { damage, health, armor };
            }

            // print out for each dragon type info as per chronological entry along with average values of
            // dragons of the same type parameters/ characteristics
            foreach(KeyValuePair<string, SortedDictionary<string, List<int>>> pair in dragonsDict)
            {
                int sumDamage = 0;
                int sumHealth = 0;
                int sumArmor = 0;
                int countDragons = 0;

                // for each dragon of a given dragon type collect parameters, sum them, and take their averages
                // to be printed on the console
                foreach(KeyValuePair<string, List<int>> dragon in pair.Value)
                {
                    sumDamage += dragon.Value.First();
                    sumArmor += dragon.Value.Last();
                    sumHealth += (dragon.Value.Sum() - (dragon.Value.First() + dragon.Value.Last()));
                    countDragons++;
                }

                double avDamage = (double)sumDamage / countDragons;
                double avHealth = (double)sumHealth / countDragons;
                double avArmor = (double)sumArmor / countDragons;
                string dragonType = pair.Key;

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", dragonType, avDamage, avHealth, avArmor);

                // for each dragon of a given type print in alphabetical order along with parameters/ chars
                foreach (KeyValuePair<string, List<int>> dragon in pair.Value)
                {
                    int[] dragonParameter = dragon.Value.ToArray();
                    int dragonDamage = dragonParameter[0];
                    int dragonHealth = dragonParameter[1];
                    int dragonArmor = dragonParameter[2];

                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Key, dragonDamage,
                            dragonHealth, dragonArmor);
                }
            }
        }
    }
}
