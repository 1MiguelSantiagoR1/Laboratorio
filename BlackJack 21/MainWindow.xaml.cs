using LibraryPOO;
using System.Collections.Generic;
using System.Windows;

namespace BlackJack_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dealer dealer = new Dealer();
        User player = new User();


        public MainWindow()
        {
            InitializeComponent();


        }

        // Meotodo Check que se encargara de evaluar el valor del maso
        public int Check(List<Card> hand)
        {
            int value = 0;
            foreach (Card card in hand)
            {
                if(value + card.Score > 21 && card.Score == 11)
                {
                    value += value + 1;
                }
                else
                {
                    value += card.Score;
                }
            }
            return value;

        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dealer = new Dealer();
            dealer.Generate();
            dealer.Randomize();
            dealer.Init();
            text1.Text = " ";

            Card c1 = dealer.Deal();
            Card c2 = dealer.Deal();

            player.Init(c1, c2);


            foreach (Card c in dealer.Deck)
            {
                text1.Text += c.Symbol + c.Suit + "\n";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Card ca = dealer.Deal();
            MessageBox.Show(ca.Suit + ca.Symbol);

            text1.Text = "";

            foreach (Card c in dealer.Deck)
            {
                text1.Text += c.Suit + c.Symbol + "\n" ;
                text2.Text += c.Score;
            }
        }
    }
}
