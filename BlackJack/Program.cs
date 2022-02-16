using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();
            bool success = false;

            Console.WriteLine($@".______    __          ___       ______  __  ___           __       ___       ______  __  ___ 
|   _  \  |  |        /   \     /      ||  |/  /          |  |     /   \     /      ||  |/  / 
|  |_)  | |  |       /  ^  \   |  ,----'|  '  /           |  |    /  ^  \   |  ,----'|  '  /  
|   _  <  |  |      /  /_\  \  |  |     |    <      .--.  |  |   /  /_\  \  |  |     |    <   
|  |_)  | |  `----./  _____  \ |  `----.|  .  \     |  `--'  |  /  _____  \ |  `----.|  .  \  
|______/  |_______/__/     \__\ \______||__|\__\     \______/  /__/     \__\ \______||__|\__\ ");

            Console.WriteLine("These are the rules of Blackjack:");
            Console.WriteLine("Each participant attempts to beat the dealer by getting a count as close to 21 as possible, without going over 21.");
            Console.WriteLine("The Dealer will get two cards, one will be hidden. Then the player will get two cards.");
            Console.WriteLine("The player can decide if they want to hit or stand, \nif they hit they get another card, if they stand the dealer shows their hidden card");

            Player player = new Player();
            Dealer dealer = new Dealer();
            Console.Write("\nPlayercards: ");
            WritePlayerCards(player);

            Console.WriteLine("Hit(1) or Stand(2)?");

            while (success == false)
            {



                string response1 = Console.ReadLine();
                int response;
                bool control = int.TryParse(response1, out response);
                if (response == 1)
                {
                    Console.WriteLine("↓Player Cards↓");
                    player.Hit();
                }
                else if (response == 2)
                {
                    success = true;
                    player.Stand();
                }
                else
                {
                    Console.WriteLine("Type either a (1) or a (2)");
                    Console.WriteLine("\nHit(1) or Stand(2)?");
                }
                if (Card.CalculateDeckValue(player.personalDeck) > 21)
                {
                    success = true;
                }

                dealer.Update();
            }

            int playerFrom21;
            int dealerFrom21;

            playerFrom21 = 21 - Card.CalculateDeckValue(player.personalDeck) >= 0 ? 21 - Card.CalculateDeckValue(player.personalDeck) : 21;
            dealerFrom21 = 21 - Card.CalculateDeckValue(dealer.personalDeck) >= 0 ? 21 - Card.CalculateDeckValue(dealer.personalDeck) : 21;

            Console.WriteLine("Players final cards");
            WritePlayerCards(player);
            Console.WriteLine();
            Console.WriteLine("Dealers final cards");
            WritePlayerCards(dealer);


            if (playerFrom21 < dealerFrom21) Console.WriteLine("Player won");
            else if (playerFrom21 > dealerFrom21) Console.WriteLine("Dealer won");
            else Console.WriteLine("bust");

            Console.ReadLine();

        }



        private static void WritePlayerCards(Player player)
        {
            for (int i = 0; i < player.personalDeck.Count; i++)
            {
                Console.Write(Card.WriteCardName(player.personalDeck[i]) + " : ");
            }
            Console.WriteLine("\n");
        }
    }
}
