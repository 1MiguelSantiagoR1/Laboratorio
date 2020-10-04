using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryPOO
{
    public class Player
    {
        private List<Card> hand;

        public List<Card> Hand { get => hand; set => hand = value; }

        public void AddCard(Card c)
        {
            hand.Add(c);
        }
    }
}
