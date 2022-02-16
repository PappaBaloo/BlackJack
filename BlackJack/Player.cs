using System;
using System.Collections.Generic;


namespace BlackJack
{
    public class Player
    {

        //de korten som player har på hand
        public List<string> personalDeck = new List<string>();

        //konstruktor för de två första korten som player tar upp
        public Player()
        {
            for (int i = 0; i < 2; i++)
            {
                personalDeck.Add(Card.PickUpCard());
            }

        }

        //för att player ska ta ett kort från decket, är virtual för override i dealer
        public virtual void Hit()
        {
            personalDeck.Add(Card.PickUpCard());

            for (int i = 0; i < personalDeck.Count; i++)
            {
                Console.WriteLine(Card.WriteCardName(personalDeck[i]));
                // Console.WriteLine(Card.GetCardValue(personalDeck[i], personalDeck));
            }
            Console.WriteLine(Card.CalculateDeckValue(personalDeck));
        }
        //För att player ska standa, är virtual för override i dealer
        public virtual void Stand()
        {
            Console.WriteLine("Player Stands");

        }
    }
}