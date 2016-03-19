using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldMaid
{
    class Table
    {
        private ArrayList _disposedCards = new ArrayList();

        public void DisposeCard(Card[] card)
        {
            _disposedCards.Add(card);
        }
    }
}
