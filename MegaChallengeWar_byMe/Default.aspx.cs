using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar_byMe
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            /*
            // Check all cards in deck
            Deck deck = new Deck();

            foreach (var card in deck._deck)
            {
                resultLabel.Text += "<br/>" + card.Kind + " " + card.Suit;
            }
            */

            Game game = new Game("Ante","Josip");
            resultLabel.Text = game.Play();
        }
    }
}