using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace MegaChallengeWar_byMe
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private Deck _deck;


        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
            _deck = new Deck();
        }

        public string Play()
        {
            string result = "<h3>Dealing cards ...</h3>";
            int round = 0; //This is for limit rounds to 500

            result += _deck.Deal(_player1, _player2);

            result += "<h3>Begin battle ...</h3>";

            while (_player1.Cards.Count != 0 || _player2.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(_player1, _player2);

                round++;
                if (round > 500)
                    break;
            }

            result += determinWinner();

            return result;
        }

        private string determinWinner()
        {
            string result = "";

            result += "<br/><span style='color:red;font-weight:bolder;'>" + _player1.Name + ": " + _player1.Cards.Count.ToString() + "</span>&nbsp;&nbsp;&nbsp;&nbsp;<span style='color:blue;font-weight:bolder;'>" + _player2.Name + ": " + _player2.Cards.Count.ToString() + "</span><br/>";

            if (_player1.Cards.Count > _player2.Cards.Count)
                result += "<br/><span style='color:red;font-weight:bolder;'><h1>" + _player1.Name + " wins the game !!!<h1/></span>";
            else
                result += "<br/><span style='color:blue;font-weight:bolder;'><h1>" + _player2.Name + " wins the game !!!<h1/></span>";

            return result;
        }
    }
}