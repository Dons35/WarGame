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

        public string returno { get; set; }      

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

            returno = duck.Distribute(player1, player2);

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
                return "Player 1 won";
            }

            else
            {
                return "Player 2 won";
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
            if (card.Value > card2.Value)
            {
                foreach (var thing in reward)
                {
                    player1.PlayerDeck.Add(thing);
                }
            }

            else
            {
                foreach (var thing in reward)
                {
                    player2.PlayerDeck.Add(thing);
                }
            }

            reward.Clear();
        }
    }
}