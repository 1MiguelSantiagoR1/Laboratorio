using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryPOO
{
    public class User : Player
    {
        public void Init(Card c1, Card c2)
        {
            AddCard(c1);
            AddCard(c2);
        }
    }
}
