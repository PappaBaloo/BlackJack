using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            Console.WriteLine($@".______    __          ___       ______  __  ___           __       ___       ______  __  ___ 
|   _  \  |  |        /   \     /      ||  |/  /          |  |     /   \     /      ||  |/  / 
|  |_)  | |  |       /  ^  \   |  ,----'|  '  /           |  |    /  ^  \   |  ,----'|  '  /  
|   _  <  |  |      /  /_\  \  |  |     |    <      .--.  |  |   /  /_\  \  |  |     |    <   
|  |_)  | |  `----./  _____  \ |  `----.|  .  \     |  `--'  |  /  _____  \ |  `----.|  .  \  
|______/  |_______/__/     \__\ \______||__|\__\     \______/  /__/     \__\ \______||__|\__\ ");

            Console.WriteLine("These are the rules of Blackjack:");
            Console.WriteLine("Each participant attempts to beat the dealer by getting a count as close to 21 as possible, without going over 21.");
            Console.WriteLine("The Dealer will get two cards, one will be hidden. Then the player will get two cards.");
            Console.WriteLine("The player can decide if they want to hit or stand, if they hit they get another card, if they stand the dealer shows their hidden card");

            Card c1 = new Card();

            // Console.WriteLine(c1.WriteCardName("H"));

            // foreach (string card in Card.allCards)
            // {
            Console.WriteLine(Card.WriteCardName(Card.allCards[generator.Next(53)]));

            Console.ReadLine();
        }
    }
}
