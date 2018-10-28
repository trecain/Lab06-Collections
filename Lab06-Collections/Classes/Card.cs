using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    public class Card
    {
        /// <summary>
        /// sets the properties of the card
        /// </summary>
        public Suit Suits { get; set; }
        public CardsNomenclature Rank { get; set; }
        public int Value { get; set; }


        /// <summary>
        /// Creates new card
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        public Card(Suit suit, CardsNomenclature rank)
        {
            Suits = suit;
            Rank = rank;
            Value = (int)rank;
        }


        /// <summary>
        /// Constructor if no parameters are passed in
        /// </summary>
        public Card()
        {
            Array suits = Enum.GetValues(typeof(Suit));
            Array ranks = Enum.GetValues(typeof(CardsNomenclature));
            Random random = new Random();
            CardsNomenclature randomCardRank = (CardsNomenclature)ranks.GetValue(random.Next(ranks.Length));
            Rank = randomCardRank;
            Value = (int)randomCardRank;
        }


        /// <summary>
        /// Enum that holds all the suit names
        /// </summary>
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        /// <summary>
        /// Enum that holds all the card names
        /// </summary>
        public enum CardsNomenclature
        {
            Ace = 14,
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }

}
