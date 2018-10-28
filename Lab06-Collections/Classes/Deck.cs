using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab06_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        /// <summary>
        /// Creates an array of named cards of type T
        /// </summary>
        T[] cards = new T[10];
        int count = 0;


        /// <summary>
        /// Adds card to deck
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length + 10);
            }
            cards[count++] = card;
        }


        /// <summary>
        /// Removes card from deck
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard(int card)
        {
            for (int i = card; i < count + 1; i++)
            {
                cards[i] = cards[i + 1];
            }
            cards[count] = default;
            count--;
        }


        /// <summary>
        /// Creates a new deck which will add cards to and returned
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public Deck<Card> ReturnSuit(Card.Suit suit)
        {
            Deck<Card> holder = new Deck<Card>();

            for (int i = 0; i < count; i++)
            {
                Card card = (Card)Convert.ChangeType(cards[i], typeof(Card));
                if (card.Suits == suit)
                {
                    holder.AddCard(card);
                }
            }
            return holder;
        }


        /// <summary>
        /// returns an individual card from deck
        /// </summary>
        /// <param name="card"></param>
        /// <returns>takes in number of card for enum</returns>
        public T IndividualCard(int card)
        {
            return cards[card];
        }


        /// <summary>
        /// returns the cards in the deck
        /// </summary>
        /// <returns>number of cards in deck</returns>
        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
