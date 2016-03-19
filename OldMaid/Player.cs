using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldMaid
{
    class Player
    {
        private Master _master;
        private Table _table;
        private Hand _hand = new Hand();
        public string Name { get; set; }

        public Player(string name, Master master, Table table)
        {
            this.Name = name;
            _master = master;
            _table = table;
        }


        public void Play(Player nextPlayer)
        {
            Hand nextHand = nextPlayer.ShowHand();

            Card pickedCard = nextHand.PickCard();

            DealCard(pickedCard);

            if(_hand.GetNumberOfCards() == 0)
            {
                _master.DeclareWin(this);
            }
        }

        public Hand ShowHand()
        {
            if(_hand.GetNumberOfCards() == 1)
            {
                _master.DeclareWin(this);
            }

            _hand.Suffle();

            return _hand;
        }

        public void DealCard(Card card)
        {
            _hand.AddCard(card);
            Card[] sameCards = _hand.FindSameNumberCard();

            if (sameCards != null)
            {
                _table.DisposeCard(sameCards);
            }
        }

        public void ReceiveCard(Card card)
        {
            DealCard(card);
        }
    }
}
