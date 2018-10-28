using System;
using Xunit;
using Lab06_Collections.Classes;
using Lab06_Collections;

namespace CardGameTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Test that a card is added to your deck
        /// </summary>
        [Fact]
        public void CanAddCardToDeck()
        {
            Card card = new Card(Card.Suit.Spades, Card.CardsNomenclature.Ace);
            Deck<Card> deck = Program.DealDeck(6);
            deck.AddCard(card);
            Assert.Equal(7, deck.Count());
        }


        /// <summary>
        /// Generates randomn card
        /// </summary>
        [Fact]
        public void CanCreateRandomCard()
        {
            Card card = new Card(Card.Suit.Clubs, Card.CardsNomenclature.King);
            Assert.Equal(Card.Suit.Clubs, card.Suits);
            Assert.Equal(Card.CardsNomenclature.King, card.Rank);
        }


        /// <summary>
        /// Creates a deck
        /// </summary>
        [Fact]
        public void CanCreateDeck()
        {
            Deck<Card> deck = Program.DealDeck(6);
            Assert.Equal(6, deck.Count());
        }


        /// <summary>
        /// Shows that a card can be removed from the deck
        /// </summary>
        [Fact]
        public void CanRemoveCardFromDeck()
        {
            Deck<Card> deck = Program.DealDeck(6);
            Card card = deck.IndividualCard(3);
            deck.RemoveCard(2);
            Assert.Equal(5, deck.Count());
            Assert.Equal(card, deck.IndividualCard(2));
        }


        /// <summary>
        /// Test ReturnShift method is working
        /// </summary>
        [Fact]
        public void ReturnShiftMethodWorks()
        {
            Card cardOne = new Card(Card.Suit.Spades, Card.CardsNomenclature.Queen);
            Card cardTwo = new Card(Card.Suit.Hearts, Card.CardsNomenclature.Eight);
            Card cardThree = new Card(Card.Suit.Clubs, Card.CardsNomenclature.Ace);
            Card cardFour = new Card(Card.Suit.Diamonds, Card.CardsNomenclature.King);
            Card cardFive = new Card(Card.Suit.Diamonds, Card.CardsNomenclature.Queen);

            Deck<Card> testDeck = new Deck<Card>();
            testDeck.AddCard(cardOne);
            testDeck.AddCard(cardTwo);
            testDeck.AddCard(cardThree);
            testDeck.AddCard(cardFour);
            testDeck.AddCard(cardFive);
            Deck<Card> deck = testDeck.ReturnSuit(Card.Suit.Diamonds);
            Assert.Equal(2, deck.Count());
            Assert.Equal(cardFive, deck.IndividualCard(1));
        }



    }
}
