using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    public class Card
    {
        public Suit Suits { get; set; }
        public CardsNomenclature Rank { get; set; }
        public int Value { get; set; }


        public Card(Suit suit, CardsNomenclature rank)
        {
            Suits = suit;
            Rank = rank;
            Value = (int)rank;
        }

        public Card()
        {
            Array suits = Enum.GetValues(typeof(Suit));
            Array ranks = Enum.GetValues(typeof(CardsNomenclature));
            Random random = new Random();
            CardsNomenclature randomCardRank = (CardsNomenclature)ranks.GetValue(random.Next(ranks.Length));
            Rank = randomCardRank;
            Value = (int)randomCardRank;
        }

        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

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
