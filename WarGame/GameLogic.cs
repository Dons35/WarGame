using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarGame
{
    public class GameLogic
    {

        private Player player1;

        private Player player2;

        private List<Card> reward;

        public string Returno { get; set; }

        public string WarString { get; set; }

        public GameLogic()
        {
            player1 = new Player() {Name = "Player 1" };
            player2 = new Player() {Name = "Player 2" };
            reward = new List<Card>();
        }

        public string Play()
        {
            Deck duck = new Deck();

            duck.Distribute(player1, player2);

            Returno = String.Format("{0} {1} {2}", "Which cards were dealt to each player?<br/><br/>", duck.Distribute(player1, player2), "<br/> ____________<br/>Begin rounds<br/>____________<br/>");

            int round = 0;

            while (player1.PlayerDeck.Count != 0 && player2.PlayerDeck.Count != 0)
            {

                Card player1go = putCardInRewardPile(player1);
                Card player2go = putCardInRewardPile(player2);

                compare(player1go, player2go, player1, player2);

                

                round++;

                if (round > 30)
                {
                    break;
                }

            }

            string Winner = whoWon();
            return Winner;
           
        }

        private string whoWon()
        {
            if (player1.PlayerDeck.Count > player2.PlayerDeck.Count)
            {
                return String.Format("{0} {1} {2} {3} {4}", "<br/>Player 1 won after 30 turns with ", player1.PlayerDeck.Count.ToString(), " cards in the deck, while Player 2 had", player2.PlayerDeck.Count.ToString(), "<br/><br/>");
            }

            else
            {
                return String.Format("{0} {1} {2} {3} {4}", "<br/>Player 2 won after 30 turns with ", player2.PlayerDeck.Count.ToString(), " cards in the deck, while Player 1 had", player1.PlayerDeck.Count.ToString(), "<br/><br/>");
            }
        }

        private Card putCardInRewardPile(Player player)
        {
            Card card = player.PlayerDeck.ElementAt(0);
            player.PlayerDeck.Remove(card);
            reward.Add(card);
            return card;
        }

        private void compare(Card card, Card card2, Player player1, Player player2)
        {

            for (int i = 0; i < 1; i++)
            {

                if (card.Value == card2.Value)
                {
                    timeForWar(player1, player2);
                    continue;
                }

                if (card.Value > card2.Value)
                {
                    foreach (var thing in reward)
                    {
                        player1.PlayerDeck.Add(thing);
                    }
                    WarString += String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", "<br/>", card.Type, " of ", card.Suit, "<br/>", card2.Type, " of ", card2.Suit, "<br/><br/>End of Round: Player 1 wins and gets the reward pile<br/>___________<br/><br/><br/>");
                }

                else
                {
                    foreach (var thing in reward)
                    {
                        player2.PlayerDeck.Add(thing);
                    }
                    WarString += String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", "<br/>", card.Type, " of ", card.Suit, "<br/>", card2.Type, " of ", card2.Suit, "<br/><br/>End of Round: Player 2 wins and gets the reward pile<br/>___________<br/><br/>");
                }

            }

            reward.Clear();
        }

        private void timeForWar(Player player1, Player player2)
        {
            for (int i = 0; i < 4; i++)
            {
                putCardInRewardPile(player1);
                putCardInRewardPile(player2);
            }

            WarString += "<br/>============WAR============<br/>";

            foreach (var grape in reward)
            {
                WarString += grape.Type + " of " + grape.Suit + "<br/>";
            }

            if (reward[reward.Count - 2].Value > reward[reward.Count - 1].Value)
            {
                WarString += String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", "<br/>End of War: Player 1 wins and gets the reward pile, because ", reward[reward.Count - 2].Type, " of ", reward[reward.Count - 2].Suit, " beats ", reward[reward.Count - 1].Type, " of ", reward[reward.Count - 1].Suit, "<br/>___________<br/><br/>");

                foreach (var noodle in reward)
                {
                    player1.PlayerDeck.Add(noodle);
                }
            }

            else if (reward[reward.Count - 1].Value > reward[reward.Count - 2].Value)
            {
                WarString += String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", "<br/>End of War: Player 2 wins and gets the reward pile, because ", reward[reward.Count - 1].Type, " of ", reward[reward.Count - 1].Suit, " beats ", reward[reward.Count - 2].Type, " of ", reward[reward.Count - 2].Suit, "<br/>___________<br/><br/>");

                foreach (var noodle in reward)
                {
                    player2.PlayerDeck.Add(noodle);
                }
            }

            else
            {
                compare(reward[reward.Count - 2], reward[reward.Count - 1], player1, player2);
            }
        }



    }
}