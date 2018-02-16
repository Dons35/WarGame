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
            GameLogic gamelogic = new GameLogic();
            gamelogic.Play();
            resultLabel.Text += gamelogic.returno;
            resultLabel.Text += gamelogic.Play();
            
        }
    }
}