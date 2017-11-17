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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // deklarerar variabler
            int ones, twos, threes, fours = int.Parse(txtFours.Text), fives, sixes, sum=0, bonus=0, total=0;


            // tilldelar värden. 
            // Konverterar från en sträng till en int med int.Parse()
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);
            threes = int.Parse(txtThrees.Text);
           // fours = int.Parse(txtFours.Text);
            fives = int.Parse(txtFives.Text);
            sixes = int.Parse(txtSixes.Text);

            // Summera värdena
            sum = ones + twos + threes + fours + fives + sixes;

            // slutligen presenteras resultatet

            txtSum.Text = sum.ToString();

            // Styrande sats

            // kontrollera om totalsumman är större än, eller lika med 63
            // om sant = ge 50 bonuspoäng
            // bool valideras som sant eller falskt
            // if (logiskt uttryck) 


            //Refaktorera = förbättra koden
            // DRY Don´t repeat yourself
            // ? operator

            // maximala poängsummman i Yatzy är 106
            //if (sum >= 106)
            //{
            //    MessageBox.Show("Den där poängsumman är orimlig");

            //    if(sum != 1000 ) // kontrollerar osasdfasdfsa df 
            //    {
            //        MessageBox.Show("Vilken fuskare du är");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Du är hyfsat ärlig i alla fall");

            //    }
            //}
            //else if (sum >= 63)
            //    bonus = 50;

            //else
            //    bonus = 0;


            int testsumma = fives % 5;

            if (fives % 5 ==0 && fives <= 25)
            {
                MessageBox.Show("detta är rimligt");
            }

            total = sum + bonus;
            txtBonus.Text = bonus.ToString();
            txtTotal.Text = total.ToString();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            // all magi
        }
    }
}
