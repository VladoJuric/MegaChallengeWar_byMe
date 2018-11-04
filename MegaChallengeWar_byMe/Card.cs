using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar_byMe
{
    public class Card
    {
        public string Kind { get; set; }
        public string Suit { get; set; }

        public int CardValue()
        {
            int value = 0;

            switch (this.Kind)
            {
                case "J":
                    value = 11;
                    break;
                case "Q":
                    value = 12;
                    break;
                case "K":
                    value = 13;
                    break;
                case "AS":
                    value = 14;
                    break;
                default:
                    value = int.Parse(this.Kind);
                    break;
            }

            return value;
        }
    }
}