using System;
using System.Collections.Generic;


namespace BlackJack
{
    public class Player
    {

        public List<string> activeCard = new List<string>();

        public Player()
        {
            for (int i = 0; i < 2; i++)
            {
                activeCard.Add(Card.PickUpCard());
            }

        }
        public void Hit()
        {
            activeCard.Add(Card.PickUpCard());

            for (int i = 0; i < activeCard.Count; i++)
            {
                Console.WriteLine(Card.WriteCardName(activeCard[i]));
            }
        }
        public void Stand()
        {
            Console.WriteLine("Fuck me daddy");

        }
    }
}