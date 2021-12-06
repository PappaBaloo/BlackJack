using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {

        private Random cardShuffler = new Random();

        private List<string> CardsNumber = new List<string> { "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        private List<string> CardID = new List<string> { };

        private string cardName;

        private int cardValue;



        public List<string> ReturnAllCards()
        {
            string[] type = new string[] { "h", "c", "e", "g" };

            List<string> allcards = new List<string>();

            for (int i = 0; i < type.Length; i++)
            {
                for (var y = 0; y < 13; y++)
                {
                    allcards.Add(type[i] + "" + y);
                }
            }
            return allcards;
        }
        public string WriteCardName(string card)
        {
            string name;

            name = card.Substring(1);

            if (card.StartsWith("h"))
            {
                name = name + "of Hearts";
            }
            return name;
        }
    }
}
