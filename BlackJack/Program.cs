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
            NewMethod(player);

            Console.WriteLine("Hit(1) or Stand(2)?");

            while (success == false)
            {


                string response1 = Console.ReadLine();
                int response;
                bool control = int.TryParse(response1, out response);
                if (response == 1)
                {

                    // success = true;
                    player.Hit();
                }
                if (response == 2)
                {
                    // success = true;
                    player.Stand();
                }
            }


            Console.ReadLine();
        }

        private static void NewMethod(Player player)
        {
            for (int i = 0; i < player.activeCard.Count; i++)
            {
                Console.WriteLine(Card.WriteCardName(player.activeCard[i]));
            }
        }
    }
}
