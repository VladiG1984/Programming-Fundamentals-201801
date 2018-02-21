using System;
using System.Linq;
using System.Collections.Generic;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, IDictionary<string, double>> countryCityDictionary = 
                    new Dictionary<string, IDictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                        .Split('|')
                        .ToArray();

                if (input[0].Equals("report"))
                {
                    break;
                }

                string country = input[1];
                string city = input[0];
                double population = double.Parse(input[2]);

                if (countryCityDictionary.ContainsKey(country))
                {
                    countryCityDictionary[country].Add(city, population);
                }
                else
                {
                    IDictionary<string, double> cityPopulation = new Dictionary<string, double>
                    {
                        { city, population }
                    };

                    //countryCityDictionary[country] = cityPopulation;

                    countryCityDictionary.Add(country, cityPopulation);
                }
            }

            // order the countries in the dictionary by the sum of the populations in each of the country's cities
            // order them in descending order
            foreach (KeyValuePair<string, IDictionary<string, double>> country in 
                countryCityDictionary.OrderByDescending(key => key.Value.Values.Sum()))
            {
                //int countryPopulation = 0;

                //foreach(KeyValuePair<string, int> city in country.Value)
                //{
                //    countryPopulation += city.Value;
                //}

                //Console.WriteLine("{0} (total population: {1})", country.Key, countryPopulation);

                // Technically, here we say that the country's population is:
                // a) take the value of the outer dictionary for each key (country)
                // b) take the value of the value of the outer dictionary (i.e., the value of the inner dictionary)
                // c) take the sum of those value from b)
                double countryPopulation = country.Value.Sum(c => c.Value);
                Console.WriteLine("{0} (total population: {1})", country.Key, countryPopulation);

                // order in descending order the cities of each country by the size of their populations;
                // if the more than one city have the same population size, then print them in chronological order
                foreach (KeyValuePair<string, double> city in country.Value.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
