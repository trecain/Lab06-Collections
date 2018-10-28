using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lab06_Collections.Classes;

namespace Lab06_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[10];
        int count = 0;

        public void AddCard(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length + 10);
            }
            cards[count++] = card;
        }

        public void RemoveCard(int card)
        {
            for (int i = card; i < count + 1; i++)
            {
                cards[i] = cards[i + 1];
            }
            cards[count] = default;
            count--;
        }

        public Deck<Card> ChooseCardSuit(Suits suit)
        {
            Deck<Card> holder = new Deck<Card>();

            for (int i = 0; i < count; i++)
            {
                Card card = (Card)Convert.ChangeType(cards[i], typeof(Card));
                if (holder.Suits == suit)
                {
                    holder.Card
                    holder.AddCard(card);
                }
            }
            return holder;
        }

        public T IndividualCard(int card)
        {
            return cards[card];
        }

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
