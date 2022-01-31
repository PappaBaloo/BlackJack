using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        public static List<string> allCards = ReturnAllCards();

        public static List<string> activeCards = new List<string>();

        private Random cardShuffler = new Random();

        private string cardName;

        private int cardValue;

        public Card()
        {
            allCards = ReturnAllCards();
        }

        private static List<string> ReturnAllCards()
        {
            string[] type = new string[] { "H", "C", "S", "D" };

            List<string> allcards = new List<string>();

            for (int i = 0; i < type.Length; i++)
            {
                for (var y = 1; y < 14; y++)
                {
                    allcards.Add(type[i] + y);
                }
            }
            return allcards;
        }

        public static string WriteCardName(string card)
        {
            string name = card.Substring(1);

            if (name.Substring(1) == "1")
            {
                name = "Ace";
            }
            else if (name.Substring(1) == "11")
            {
                name = "Jack";
            }
            else if (name.Substring(1) == "12")
            {
                name = "Queen";
            }
            else if (name.Substring(1) == "13")
            {
                name = "King";
            }

            if (card.StartsWith("H"))
            {
                name += " of Hearts";
            }
            if (card.StartsWith("C"))
            {
                name += " of Clubs";
            }
            if (card.StartsWith("S"))
            {
                name += " of Spades";
            }
            if (card.StartsWith("D"))
            {
                name += " of Diamonds";
            }
            return name;
        }
    }
}
