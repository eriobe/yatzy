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

namespace Föreläsning2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // globala variabler
        string firstName;
        public MainWindow()
        {
            InitializeComponent();
            txtValue.Text = "Fyll i ditt namn";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            // skapar en variabel
            // hårt typat programmeringsspråk

            // namn Namn NAMn

            // det finns olika datatyper

            // datatyp variabelnamn plus eventuellt ett grundvärde

            // deklarerar en variabel av datatypen string
            string textboxValue;
            string lastName = "Öberg";

            // tilldelar variabeln ett värde från textboxen

            //textboxValue = textboxValue + txtValue.Text;
            //textboxValue = textboxValue + " Jag hoppas du mår bra";

            textboxValue = txtValue.Text;


            MessageBox.Show("Hej " + lastName + " " + txtValue.Text + " jag hoppas du mår bra.");
            firstName = "Olle";
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            // variablers räckvidd
            firstName = "Erik";
            string lastName = "Äberg";
            //typkonvertering

            // gör om från en datatyp till en annan

            // i det här fallet från en string till en int
            int age = int.Parse(txtValue.Text);

            // alla ljuger om sin ålder
            age += 5;
            MessageBox.Show(age.ToString());

        }

        private void btnKnapp_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            MessageBox.Show(content);
        }

        private void btnKnapp_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void label_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void whichDay(object sender, RoutedEventArgs e)
        {

        }

        private void btnWeekday_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
