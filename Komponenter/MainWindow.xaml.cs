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

namespace Komponenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // tilldelar knappen ett nytt värde för egenskapen Content
            btnOk.Content = "Ny text";

            string buttonText;
            // Läser värdet på egenskapen Content och lägger den i en variabel av datatypen string
            buttonText = btnOk.Content.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // slumpgenerator
            Random random = new Random();

            // mitt slumpade värde
            int result = random.Next(1,101);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Den kod du skriver här kommer
            // köras när användaren klickar på
            // knappen som heter btnOk

            if (chkCandies.IsChecked == true)
            {

            }

            if (chkVegetables.IsChecked == false)
            {
                // du borde äta mer grönsaker
            }

            //if (rdoCandies.IsChecked==true)
            //{

            //}

            lblFirstname.Content = "Förnamn";
            string firstname = lblFirstname.Content.ToString();
            string message = "Det här är ett meddelande. Eftersom texten i det här meddelandet är väldigt långt borde det inte rymmas på en enda rad.";
            tblMessage.Text = message;
            lblFirstname.Content = message;
        }

        private void tblMessage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(tblMessage.Text);
        }
    }
}
