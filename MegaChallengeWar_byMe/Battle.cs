using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar_byMe
{
    public class Battle
    {
        private List<Card> _bounty;
        private StringBuilder _sb;

        public Battle()
        {
            _bounty = new List<Card>();
            _sb = new StringBuilder();
        }

        public string PerformBattle(Player player1, Player player2)
        {
            Card player1Card = getCard(player1);
            Card player2Card = getCard(player2);

            performEvaluation(player1, player2, player1Card, player2Card);
            return _sb.ToString();
        }

        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0); //TODO:  Error ElementAt(0)
            player.Cards.Remove(card);
            _bounty.Add(card);

            return card;
        }

        private void performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            displayBattleCards(card1, card2);

            if (card1.CardValue() == card2.CardValue())
                war(player1,player2);

            if (card1.CardValue() > card2.CardValue())
                awardWinner(player1,player1);
            else
                awardWinner(player2,player1);
        }

        private void awardWinner(Player playerFirst, Player playerCheck)
        {
            if (_bounty.Count == 0) return; 

            displayBounyCards();

            playerFirst.Cards.AddRange(_bounty);
            _bounty.Clear();

            if (playerFirst.Name == playerCheck.Name)
            {
                _sb.Append("<br/><strong>");
                _sb.Append("<span style='color:red;font-weight:bolder;'>");
;               _sb.Append(playerFirst.Name);
                _sb.Append(" wins!!!</span></strong><br/>");
            }
            else
            {
                _sb.Append("<br/><strong>");
                _sb.Append("<span style='color:blue;font-weight:bolder;'>");
                ; _sb.Append(playerFirst.Name);
                _sb.Append(" wins!!!</span></strong><br/>");
            }
        }

        private void war(Player player1, Player player2)
        {
            _sb.Append("<br/><br/>********************    WAR    ********************<br/>");

            getCard(player1);
            Card warCard1 = getCard(player1);
            getCard(player1);

            getCard(player2);
            Card warCard2 = getCard(player2);
            getCard(player2);

            performEvaluation(player1, player2, warCard1, warCard2);
        }

        private void displayBattleCards(Card card1, Card card2)
        {
            _sb.Append("<br/>Battle Cards:");
            _sb.Append("<span style='color:red;font-weight:bolder;'>");
            _sb.Append(card1.Kind);
            _sb.Append(" ");
            _sb.Append(card1.Suit);
            _sb.Append("</span>    vs    ");
            _sb.Append("<span style='color:blue;font-weight:bolder;'>");
            _sb.Append(card2.Kind);
            _sb.Append(" ");
            _sb.Append(card2.Suit);
            _sb.Append("</span>");
        }

        private void displayBounyCards()
        {
            _sb.Append("<br/>Bounty ... ");

            foreach (var card in _bounty)
            {
                _sb.Append("<br/>&nbsp;&nbsp;&nbsp;&nbsp;");
                _sb.Append(card.Kind);
                _sb.Append(" ");
                _sb.Append(card.Suit);
            }
        }
    }
}