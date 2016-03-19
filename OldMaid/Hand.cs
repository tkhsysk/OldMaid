using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldMaid
{
    class Hand
    {
        private ArrayList _hand = new ArrayList();

        public void AddCard(Card card)
        {
            _hand.Add(card);
        }

        public Card PickCard()
        {
            Card pickedCard = (Card)_hand[0];
            _hand.RemoveAt(0);

            return pickedCard;
        }

        public void Suffle()
        {
            int number = _hand.Count;
            int pos;

            for(int count = 0; count < number * 2; count++)
            {
                Random rand = new Random();
                pos = rand.Next(number);

                Card pickedCard = (Card)_hand[pos];
                _hand.RemoveAt(pos);
                _hand.Add(pickedCard);
            }
        }

        public int GetNumberOfCards()
        {
            return _hand.Count;
        }

        public Card[] FindSameNumberCard()
        {
            int _numberOfCards = _hand.Count;
            Card[] _sameCards = null;

            if (_numberOfCards > 0)
            {
                int lastIndex = _numberOfCards - 1;
                Card lastAddedCard = (Card)_hand[lastIndex];
                int lastAddedCardNum = lastAddedCard.GetNumber();

                for(int index = 0; index < lastIndex; index++)
                {
                    Card card = (Card)_hand[index];
                    if(card.GetNumber() == lastAddedCardNum)
                    {
                        _sameCards = new Card[2];
                        _sameCards[0] = lastAddedCard;
                        _sameCards[1] = card;

                        _hand.RemoveAt(lastIndex);
                        _hand.RemoveAt(index);

                        break;
                    }
                }
            }

            return _sameCards;
        }
    }
}
