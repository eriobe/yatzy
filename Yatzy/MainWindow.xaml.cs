using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yatzy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        // en array av alla tärningar
        int[] dices = new int[5];
        // skapa en array som visar vilka tärningar vi vill spara
        // array of bool
        bool[] savedDices = new bool[5];

        public MainWindow()
        {
            InitializeComponent();
        }
        // Min första metod
        /// <summary>
        /// Slumpar värdet av en tärning
        /// </summary>
        /// <returns></returns>
        private int SlumpaEnTärning() // metodhuvud. 
        {
            /* Den här metoden slumpar värdet av
             * en tärning. Svaret blir mellan 1 och 6
             */


            // skapar ett objekt av typen Random
            // objekt kan också kallas för instans
            Random random = new Random();
            // slumpa fram ett värde mellan ett och sex 
            // vilket motsvarar ett tärningsslag
            int randomDice = random.Next(1, 7);
            return randomDice;
        }

        private int[] NyMetod(int ones, int twos, int threes, int fours, int fives, int sixes, int sum, int bonus)
        {
            return null;
        }
        /// <summary>
        /// returns random int values for five dices
        /// </summary>
        /// <returns></returns>
        private int[] RollDices(bool[] savedDices)
        {
            Random random = new Random();
            int[] myDices = new int[5];

            // skapar en for-loop
            // startvärde  slutvärde   villkor för att öka
            for (int i = 0; i < myDices.Count(); i++)
            {
                if (!savedDices[i])
                {
                    myDices[i] = random.Next(1, 7);
                }
            }

            return myDices;

        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            

            // deklarerar variabler
            int ones, twos, threes, fours, fives, sixes;
            int sum =0, bonus=0, total=0;

            
            


            // gör om detta i en loop
            // iterativ sats
           
            if (optSaveDiceOne.IsChecked==true)
            {
                savedDices[0] = true;
            }
            // ett metodanrop
            dices = RollDices(savedDices);

            textDiceOne.Text = string.Empty;
            textDiceOne.Text = dices[0].ToString();
            textDiceTwo.Text = dices[1].ToString();
            textDiceThree.Text = dices[2].ToString();
            textDiceFour.Text = dices[3].ToString();
            textDiceFive.Text = dices[4].ToString();

            // MessageBox.Show(string.Format("Tärningar visar {0} {1} {2} {3} {4}",dices[0], dices[1], dices[2], dices[3], dices[4]));
            // tilldelar värden. 
            // Konverterar från en sträng till en int med int.Parse()
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);
            threes = int.Parse(txtThrees.Text);
            fours = int.Parse(txtFours.Text);
            fives = int.Parse(txtFives.Text);
            sixes = int.Parse(txtSixes.Text);

            ones = 4;


            // Summera värdena
            sum = ones + twos + threes + fours + fives + sixes;

            // slutligen presenteras resultatet

            txtSum.Text = sum.ToString();

            // Styrande sats

            //kontrollera om totalsumman är större än, eller lika med 63
            // om sant = ge 50 bonuspoäng
            // bool valideras som sant eller falskt
            // if (logiskt uttryck) 


            //Refaktorera = förbättra koden
            // DRY Don´t repeat yourself
            // ? operator
            // är summan tillåten enligt reglerna?
            if (!IsSumValid())
                MessageBox.Show("nädu");
           
            total = sum + bonus;
            txtBonus.Text = bonus.ToString();
            txtTotal.Text = total.ToString();
        }

        private bool IsSumValid(int sum)
        {
            // maximala poängsummman i Yatzy är 106
            if (sum >= 106)
            {
                MessageBox.Show("Den där poängsumman är orimlig");

                if (sum != 1000)
                {
                    MessageBox.Show("Vilken fuskare du är");
                }
                else
                {
                    MessageBox.Show("Du är hyfsat ärlig i alla fall");

                }
            }
            else if (sum >= 63)
                bonus = 50;

            else
                bonus = 0;

            return true;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            // all magi
        }
    }
}
