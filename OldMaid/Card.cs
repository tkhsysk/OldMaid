using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldMaid
{
    class Card
    {
        public const int JOKER = 0;
        public const int SUIT_SPADE =1;
        public const int SUIT_DIAMOND = 2;
        public const int SUIT_CLUB = 3;
        public const int SUIT_HEART = 4;

        private int _suit;
        private int _number;

        public Card(int suit, int number)
        {
            _suit = suit;
            _number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

    }
}
