using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryPOO
{
    public class Dealer : Player
    {
        private List<Card> deck;
        public List<Card> Deck { get => deck; set => deck = value; }

        // Metodo Generate que se encargara de crear todas las posbiles combinaciones de cartas
        public void Generate()
        {
            deck = new List<Card>();
            Hand = new List<Card>();

            char[] suits = { '♦', '♣', '♠', '♥' };
            string[] symbols = { "A", "2", "3", "4","5","6","7","8","9","10","J","Q","K" };

            foreach (char uno in suits)
            {
                foreach (string dos in symbols)
                {
                    Card c = new Card(uno, dos);
                    Deck.Add(c);   
                }
            }

        }

        // Se crea el metodo Randomize que desordene el maso

        public void Randomize()
        {
            Random rnd = new Random();
            this.deck = this.deck.OrderBy(x => (rnd.Next())).ToList();
        }

        // Metodo Deal que se encargara de eliminar la primer carta del maso del jugador
        public Card Deal()
        {
            Card c = this.deck.First();
            this.deck.Remove(c);
            return c;
        }
        public void Init()
        {
            AddCard(Deal());
            AddCard(Deal());
        }
    }
}
