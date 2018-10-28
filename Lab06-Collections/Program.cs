using System;
using Lab06_Collections.Classes;

namespace Lab06_Collections
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Drawl();
        }

        public static void Drawl()
        {
            Console.WriteLine("Lab 06: Card Game");

            Deck<Card> dealer = DealDeck(15);
            Console.WriteLine($"The number of cards in your deck {dealer.Count()}");
            Console.WriteLine("The cards in your deck are:");
            Console.ReadKey();
            ViewAllCards(dealer);
            Console.WriteLine("");
            Console.WriteLine($"Removing {dealer.IndividualCard(10).Rank} of {dealer.IndividualCard(10).Suits}");
            dealer.RemoveCard(10);
            Console.WriteLine("");
            Console.WriteLine("Press enter to see cards left");
            Console.ReadKey();
            Console.WriteLine("cards left:");
            Console.WriteLine("");
            ViewAllCards(dealer);
            Console.WriteLine();
            Console.WriteLine("Thank you for checking out my game");
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Creates a random deck of the amount of cards inputted.
        /// </summary>
        /// <param name="x">The number of cards we want to create for the deck</param>
        /// <returns>a deck of 25 card objects</returns>
        public static Deck<Card> DealDeck(int x)
        {
            Deck<Card> result = new Deck<Card>();
            for (int i = 0; i < x; i++)
            {
                result.AddCard(new Card());
            }
            return result;
        }

        /// <summary>
        /// Console writes all the cards in the deck
        /// </summary>
        /// <param name="deck">The deck of cards you want printed</param>
        public static void ViewAllCards(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suits}.");
            }
        }

    }
}
    

