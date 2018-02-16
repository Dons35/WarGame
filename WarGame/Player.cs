﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarGame
{
    public class Player
    {
        public string Name { get; set; }

        public List<Card> PlayerDeck { get; set; }

        public Player()
        {
            PlayerDeck = new List<Card>();
        }
    }
}