using System;

namespace BlackJack
{
    public class Dealer : Player
    {
        //En automatisk funktion som tar kort åt dealer enligt blackjack reglerna
        public void Update()
        {
            Console.WriteLine("\nDEALER \n");
            if (Card.CalculateDeckValue(personalDeck) == 17)
            {
                Stand();
            }
            else
            {
                Hit();
            }
        }
        //Säger dealer stands istället för player stands
        public override void Stand()
        {
            Console.WriteLine("Dealer stands");
        }
        //gör så att dealern hittar istället för playern (typ lmao)
        public override void Hit()
        {
            Console.WriteLine("Dealer hits");
            base.Hit();
        }

    }
}