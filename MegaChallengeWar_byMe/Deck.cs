using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar_byMe
{
    public class Deck
    {
        private List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            string[] kinds = new string[] { "AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = new string[] { "&spades;", "&clubs;", "&hearts;", "&diams;" };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    _deck.Add(new Card() { Kind = kind, Suit = suit });
                }
            }
        }

        public string Deal(Player player1, Player player2)
        {
            while (_deck.Count > 0)
            {
                dealCards(player1,1);
                dealCards(player2,0);
                _sb.Append("<br/>");
            }

            return _sb.ToString();
        }

        private void dealCards(Player player, int format)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            if (format == 1)
            {
                _sb.Append("<span style='color:red;font-weight:bolder;'>");
                _sb.Append(player.Name);
                _sb.Append("</span>: ");
                _sb.Append(card.Kind);
                _sb.Append(" ");
                _sb.Append(card.Suit);

                if (card.Kind == "AS")
                    _sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                else if (card.Kind == "10")
                    _sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                else if (card.Kind == "Q")
                    _sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                else
                    _sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
            }
            else if (format == 0)
            {
                _sb.Append("<span style='color:blue;font-weight:bolder;'>");
                _sb.Append(player.Name);
                _sb.Append("</span>: ");
                _sb.Append(card.Kind);
                _sb.Append(" ");
                _sb.Append(card.Suit);
            }
            else
            {
                _sb.Append(player.Name);
                _sb.Append(": ");
                _sb.Append(card.Kind);
                _sb.Append(" ");
                _sb.Append(card.Suit);
            }
        }
    }
}