using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            int sum = 0;

            string[] hand = Console.ReadLine()
                .Split(new char[] { ' ',':',',' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = "";

            List<string> cards = new List<string>();

            while (hand[0] != "JOKER")
            {
                name = hand[0];
                cards = hand.Skip(1).ToList();
                cards = cards.Distinct().ToList();

                if (!players.ContainsKey(name))
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine()
                .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            int multiplayer = 0;
            int mainValue = 0;
            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplayer = 4;
                            break;
                        case 'H':
                            multiplayer = 3;
                            break;
                        case 'D':
                            multiplayer = 2;
                            break;
                        case 'C':
                            multiplayer = 1;
                            break;

                    }
                    string currentCard = card.Remove(card.Length - 1, 1);

                    switch (currentCard)
                    {
                        case "J":
                            mainValue = 11;
                            break;
                        case "Q":
                            mainValue = 12;
                            break;
                        case "K":
                            mainValue = 13;
                            break;
                        case "A":
                            mainValue = 14;
                            break;
                        default: mainValue = int.Parse(currentCard);
                            break;
                    }
                    sum += multiplayer * mainValue;
                }
                Console.WriteLine($"{player.Key}: {sum}");
                sum = 0;
            }
        }
    }
}
