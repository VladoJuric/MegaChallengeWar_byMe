using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar_byMe
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player(string playerName)
        {
            Name = playerName;
            Cards = new List<Card>();
        }
    }
}