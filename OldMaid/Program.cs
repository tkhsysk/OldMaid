using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldMaid
{
    class Program
    {
        static void Main(string[] args)
        {
            Master master = new Master();

            Table field = new Table();

            Player murata = new Player("村田", master, field);
            Player yamada = new Player("山田", master, field);
            Player saito = new Player("斉藤", master, field);

            master.RegisterPlayer(murata);
            master.RegisterPlayer(saito);
            master.RegisterPlayer(yamada);

            Hand trump = CreateTrump();

            master.PrepareGame(trump);

            master.StartGame();

            Console.ReadLine();
        }

        private static Hand CreateTrump()
        {
            Hand trump = new Hand();

            for(int i=1; i<=13; i++)
            {
                trump.AddCard(new Card(Card.SUIT_CLUB, i));
                trump.AddCard(new Card(Card.SUIT_DIAMOND, i));
                trump.AddCard(new Card(Card.SUIT_HEART, i));
                trump.AddCard(new Card(Card.SUIT_SPADE, i));
            }

            trump.AddCard(new Card(0, Card.JOKER));

            return trump;
        }
    }
}
