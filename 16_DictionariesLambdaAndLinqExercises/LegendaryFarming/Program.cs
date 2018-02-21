using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, long> keyMaterialsDict = new Dictionary<string, long>
            {
                { "shards", 0 }, { "fragments", 0}, { "motes", 0}
            };

            IDictionary<string, long> junkMaterialsDict = new SortedDictionary<string, long>();

            bool LegendaryItemObtained = false;
                        
            while (!LegendaryItemObtained)
            {
                List<string> materialInput = Console.ReadLine()
                        .ToLower()
                        .Split(' ')
                        .Where(w => w != "")
                        .ToList();

                for (int i = 0; i < materialInput.Count; i++)
                {
                    long quantity = long.Parse(materialInput[i]);
                    i++;
                    string material = materialInput[i];

                    if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes")) {

                        if (!keyMaterialsDict.ContainsKey(material))
                        {
                            keyMaterialsDict.Add(material, quantity);
                        }
                        else
                        {
                            keyMaterialsDict[material] += quantity;
                        }

                        if (keyMaterialsDict[material] > 250)
                        {
                            LegendaryItemObtained = true;
                            keyMaterialsDict[material] -= 250;

                            switch (material)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                                //default:
                                //    Console.WriteLine("No key material obtained!");
                                //    break;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterialsDict.ContainsKey(material))
                        {
                            junkMaterialsDict.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterialsDict[material] += quantity;
                        }
                    }
                }
            }

            // order key materials - first in descending order by quantity, and then in alphabetical order
            // by name of material
            IDictionary<string, long> orderedKeyMaterialsDict = keyMaterialsDict
                    .OrderByDescending(pair => pair.Value)
                    .ThenBy(pair => pair.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach(KeyValuePair<string, long> keyMaterial in orderedKeyMaterialsDict)
            {
                string material = keyMaterial.Key;
                long quantity = keyMaterial.Value;

                Console.WriteLine("{0}: {1}", material, quantity);
            }

            foreach (KeyValuePair<string, long> junkMaterial in junkMaterialsDict)
            {
                string material = junkMaterial.Key;
                long quantity = junkMaterial.Value;

                Console.WriteLine("{0}: {1}", material, quantity);
            }

        }
    }
}
