using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        public string card;

        public static List<string> allCards = ReturnAllCards();

        public static List<string> activeCards = allCards;

        private static Random cardShuffler = new Random();

        private static bool daddyElias = false;

        //Konstruktor
        public Card()
        {
            //Returnar alla cards in i allCards
            allCards = ReturnAllCards();
        }

        private static List<string> ReturnAllCards()
        {
            string[] type = new string[] { "H", "C", "S", "D" };

            List<string> allcards = new List<string>();

            //Gör alla kort i decket
            for (int i = 0; i < type.Length; i++)
            {
                for (var y = 1; y < 14; y++)
                {
                    allcards.Add(type[i] + y);
                }
            }
            return allcards;
        }

        //Används för att plocka upp kort från decket i player-klassen
        public static string PickUpCard()
        {
            string card = activeCards[cardShuffler.Next(0, activeCards.Count)];

            activeCards.Remove(card);

            return card;
        }

        //används för att skriva ut korten till dess fulla namn
        public static string WriteCardName(string card)
        {
            string name = card.Substring(1);

            if (name == "1")
            {
                name = "Ace";
            }
            else if (name == "11")
            {
                name = "Jack";
            }
            else if (name == "12")
            {
                name = "Queen";
            }
            else if (name == "13")
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

        //Hämtar valuet från kortens string 
        public static int GetCardValue(string card, List<string> deck)
        {
            List<string> deckSinCard = new List<string>();
            foreach (string s in deck)
            {
                deckSinCard.Add(s);
            }
            deckSinCard.Remove(card);


            string cardName = card.Substring(1);

            int cardValue;

            bool cardTryparse = int.TryParse(cardName, out cardValue);

            if (cardValue == 11 || cardValue == 12 || cardValue == 13) cardValue = 10;

            if (cardValue == 1)
            {
                bool maxValue = false;
                foreach (string sring in deck)
                {
                    if (CalculateDeckValue(deckSinCard) >= 21) maxValue = true;
                }
                if (maxValue) cardValue = 1;
                else daddyElias = true;
            }

            return cardValue;
        }
        //Kalkylerar player eller dealerns egna decks totala value
        public static int CalculateDeckValue(List<string> deck)
        {
            int values = 0;
            foreach (string card in deck)
            {
                values += GetCardValue(card, deck);
            }

            if (daddyElias) values += 10;
            return values;
        }

    }
}
