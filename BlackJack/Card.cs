using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        public static List<string> allCards = ReturnAllCards();

        public static List<string> activeCards = allCards;

        private static Random cardShuffler = new Random();

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
        public static string PickUpCard()
        {
            string card = activeCards[cardShuffler.Next(0, activeCards.Count)];

            activeCards.Remove(card);

            return card;

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
            else if (card.StartsWith("C"))
            {
                name += " of Clubs";
            }
            else if (card.StartsWith("S"))
            {
                name += " of Spades";
            }
            else if (card.StartsWith("D"))
            {
                name += " of Diamonds";
            }
            return name;
        }
        public static string GetCardValue(string card, List<string> playerDeck)
        {
            string cardName = card.Substring(1);

            int cardValue;

            bool cardTryparse = int.TryParse(cardName, out cardValue);

            Console.WriteLine(cardValue);

            return cardName;
        }

    }
}
