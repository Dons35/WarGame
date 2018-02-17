using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarGame
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {

            resultLabel.Text = "";

            GameLogic gamelogic = new GameLogic();

            resultLabel.Text += gamelogic.Play(); // this plays the game and displays the output of the play method, which is a string saying who won

            resultLabel.Text += gamelogic.Returno; //this displays which cards were dealt to each playerdeck at the beginning

            resultLabel.Text += gamelogic.WarString; //this lists all the wars and rounds that happened during the game and which cards were involved
            
        }
    }
}

/*
    When war happens in this game, each player puts down three face down cards, then play another final comparison for a
    rewards total of 10. This code also supports chained wars, they just might not happen very often. When the
    two comparison cards at the end of a war are equal, each player then puts down three more reward cards followed
    by a comparison card for a total of 8 in the second war. So a double war reward will be 18 cards.
*/