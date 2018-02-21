using System;
using System.Linq;
using System.Collections.Generic;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, List<string>> peopleAndCardsList = new Dictionary<string, List<string>>();

            // Read entries and depending on entry text take action
            while (true)
            {
                // split person's name from cards or take joker as input
                string[] input = Console.ReadLine().Split(':').ToArray();

                if (input[0].Equals("JOKER"))
                {
                    break;
                }
                else
                {
                    // take person's name and create a list of the cards in the input
                    string name = input[0];
                    string cards = input[1];
                    List<string> handOfCards = cards
                            .Split(',')
                            .Select(card => card.Trim())
                            .Distinct()
                            .ToList();

                    // if person's name already exists in the dictionary of names and final cards, we add the
                    // new entry of cards in the list of cards for the given person, and make each card be unique
                    // within that list, as per problem's directions;
                    // if person's name does not exist in the dictionary of names and final cards, we add the
                    // new entry of cards, which we have already made unique by card;
                    if (peopleAndCardsList.ContainsKey(name))
                    {
                        peopleAndCardsList[name] = peopleAndCardsList[name]
                                    .Concat(handOfCards)
                                    .Distinct()
                                    .ToList();
                    }
                    else
                    {
                        peopleAndCardsList.Add(name, handOfCards);
                    }
                }
            }

            // map cards in the final hand of each person with points according to card's power and type
            // then print to each person the value of his final hands of unique cards
            foreach (KeyValuePair<string, List<string>> item in peopleAndCardsList)
            {
                // create list of cards values and card types
                string[] cardPower = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                string[] cardType = { "S", "H", "D", "C" };
                List<string> handOfFinalCard = item.Value;

                // map card power & type from characters to numbers
                int[] cardPowerAndTypeMap = new int[handOfFinalCard.Count];
                // map card type from characters to numbers
                //IDictionary<string, int> cardTypeMap = new Dictionary<string, int>();

                // map to each card in a given person's hand its power and type in numbers
                int count = 0;
                foreach (string card in handOfFinalCard)
                {
                    bool foundCardValue = false;

                    for (int pow = 0; pow < cardPower.Length; pow++)
                    {
                        for (int t = 0; t < cardType.Length; t++)
                        {

                            if (card == cardPower[pow] + cardType[t])
                            {
                                cardPowerAndTypeMap[count] = (pow + 2) * (4 - t);
                                count++;
                                foundCardValue = true;
                                break;
                            }
                        }

                        if (foundCardValue)
                        {
                            break;
                        }
                    }
                }

                string person = item.Key;
                int valueInFinalCard = cardPowerAndTypeMap.Sum();

                // print person's name and his/ her final cards' value
                Console.WriteLine("{0}: {1}", person, valueInFinalCard);
            }
        }
    }
}
