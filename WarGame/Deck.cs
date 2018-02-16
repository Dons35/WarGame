using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarGame
{
    public class Deck
    {

        private List<Card> listOfCard;

        private string words;

        public Deck()
        {
            listOfCard = new List<Card>()
            {
                {new Card() {Type = "Ace", Suit = "Hearts", Value = 14}},
                {new Card() {Type = "Two", Suit = "Hearts", Value = 2 }},
                {new Card() {Type = "Three", Suit = "Hearts", Value = 3 }},
                {new Card() {Type = "Four", Suit = "Hearts", Value = 4 }},
                {new Card() {Type = "Five", Suit = "Hearts", Value = 5 }},
                {new Card() {Type = "Six", Suit = "Hearts", Value = 6 }},
                {new Card() {Type = "Seven", Suit = "Hearts", Value = 7 }},
                {new Card() {Type = "Eight", Suit = "Hearts", Value = 8 }},
                {new Card() {Type = "Nine", Suit = "Hearts", Value = 9 }},
                {new Card() {Type = "Ten", Suit = "Hearts", Value = 10 }},
                {new Card() {Type = "Jack", Suit = "Hearts", Value = 11 }},
                {new Card() {Type = "Queen", Suit = "Hearts", Value = 12 }},
                {new Card() {Type = "King", Suit = "Hearts", Value = 13 }},



                {new Card() {Type = "Ace", Suit = "Diamonds", Value = 14 }},
                {new Card() {Type = "Two", Suit = "Diamonds", Value = 2 }},
                {new Card() {Type = "Three", Suit = "Diamonds", Value = 3 }},
                {new Card() {Type = "Four", Suit = "Diamonds", Value = 4 }},
                {new Card() {Type = "Five", Suit = "Diamonds", Value = 5 }},
                {new Card() {Type = "Six", Suit = "Diamonds", Value = 6 }},
                {new Card() {Type = "Seven", Suit = "Diamonds", Value = 7 }},
                {new Card() {Type = "Eight", Suit = "Diamonds", Value = 8 }},
                {new Card() {Type = "Nine", Suit = "Diamonds", Value = 9 }},
                {new Card() {Type = "Ten", Suit = "Diamonds", Value = 10 }},
                {new Card() {Type = "Jack", Suit = "Diamonds", Value = 11 }},
                {new Card() {Type = "Queen", Suit = "Diamonds", Value = 12 }},
                {new Card() {Type = "King", Suit = "Diamonds", Value = 13 }},



                {new Card() {  Type = "Ace", Suit = "Spades", Value = 14 }},
                {new Card() {  Type = "Two", Suit = "Spades", Value = 2 }},
                {new Card() {  Type = "Three", Suit = "Spades", Value = 3 }},
                {new Card() {  Type = "Four", Suit = "Spades", Value = 4 }},
                {new Card() {  Type = "Five", Suit = "Spades", Value = 5 }},
                {new Card() {  Type = "Six", Suit = "Spades", Value = 6 }},
                {new Card() {  Type = "Seven", Suit = "Spades", Value = 7 }},
                {new Card() {  Type = "Eight", Suit = "Spades", Value = 8 }},
                {new Card() {  Type = "Nine", Suit = "Spades", Value = 9 }},
                {new Card() {  Type = "Ten", Suit = "Spades", Value = 10 }},
                {new Card() {  Type = "Jack", Suit = "Spades", Value = 11 }},
                {new Card() {  Type = "Queen", Suit = "Spades", Value = 12 }},
                {new Card() {  Type = "King", Suit = "Spades", Value = 13 }},



                {new Card() {  Type = "Ace", Suit = "Clubs", Value = 14 }},
                {new Card() {  Type = "Two", Suit = "Clubs", Value = 2 }},
                {new Card() {  Type = "Three", Suit = "Clubs", Value = 3 }},
                {new Card() {  Type = "Four", Suit = "Clubs", Value = 4 }},
                {new Card() {  Type = "Five", Suit = "Clubs", Value = 5 }},
                {new Card() {  Type = "Six", Suit = "Clubs", Value = 6 }},
                {new Card() {  Type = "Seven", Suit = "Clubs", Value = 7 }},
                {new Card() {  Type = "Eight", Suit = "Clubs", Value = 8 }},
                {new Card() {  Type = "Nine", Suit = "Clubs", Value = 9 }},
                {new Card() {  Type = "Ten", Suit = "Clubs", Value = 10 }},
                {new Card() {  Type = "Jack", Suit = "Clubs", Value = 11 }},
                {new Card() {  Type = "Queen", Suit = "Clubs", Value = 12 }},
                {new Card() {  Type = "King", Suit = "Clubs", Value = 13 }},
            };
        }

        Random randomguy = new Random();

        public string Distribute(Player player1, Player player2)
        {

            while (listOfCard.Count > 0)
            {

                helpme(player1);
                helpme(player2);
            }

            return words;

        }

        private void helpme(Player player)
        {
            Card place = listOfCard.ElementAt(randomguy.Next(listOfCard.Count));
            player.PlayerDeck.Add(place);
            listOfCard.Remove(place);

            words += String.Format("{0}: {1} of {2}{3}", player.Name, place.Type, place.Suit, "<br/>");
        }

    }
}