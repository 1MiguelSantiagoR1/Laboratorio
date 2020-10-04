using System;
using System.Collections.Generic;

namespace LibraryPOO
{
    public class Card
    {
        private char suit;
        private string symbol;
        private int score;
        string color;

        // Creacion de los atributos con sus respectivos getters y setters
        public char Suit { get => suit; set => suit = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public int Score { get => score; set => score = value; }
        public string Color { get => color; set => color = value; }
        public Card()
        {

        }

        public Card(char suit, string symbol)
        {
            this.suit = suit;
            this.symbol = symbol;

            // Con este if se busca especificar de que color sera cada carta

            if (suit.Equals('♥') || suit == '♦')
            {
                this.color = "Rojo";
            }
            else
            {
                this.color = "Negro";
            }

            int value;

            try
            {
                value = Convert.ToInt32(symbol);

            }
            catch (FormatException fe )

             // Con esto se busca darle un valor a cada carta del atributo symbol

            {
                if (symbol == "A")
                {
                    value = 11;
                }
                else
                {
                    value = 10;
                }
                if (symbol == "2")
                {
                    value = 2;
                }
                if (symbol == "3")
                {
                    value = 3;
                }
                if (symbol == "4")
                {
                    value = 4;
                }
                if (symbol == "5")
                {
                    value = 5;
                }
                if (symbol == "6")
                {
                    value = 6;
                }
                if (symbol == "7")
                {
                    value = 7;
                }
                if (symbol == "8")
                {
                    value = 8;
                }
                if (symbol == "9")
                {
                    value = 9;
                }
                if (symbol == "10")
                {
                    value = 2;
                }
                if (symbol == "J")
                {
                    value = 12;
                }
                if (symbol == "Q")
                {
                    value = 13;
                }
                if (symbol == "K")
                {
                    value = 14;
                }
            }

            this.score = value;
        }
    }
}
