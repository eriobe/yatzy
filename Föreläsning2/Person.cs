using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning2
{
    [Serializable]

    class Person
    {
        // en grundläggande princip i objektorienterad programmering är
        // inkapsling

        // fields, fält
        private string adress;

        // skapar autoproperties
        public List<Bil> Bilar { get; set; }
        public string Förnamn { get; set; }
        public int NyEgenskap { get; set; }
        public string Efternamn { get; set; }
        public double Längd { get; set; }
        public double Vikt { get; set; }

        public int Ålder { get; set; }
        public Person()
        {
            Bilar = new List<Bil>();
        }
        public double Bmi
        {
            get { return BmiKalkylator(); }
        }


        // skapar en egenskap med en backing field
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private double BmiKalkylator()
        {
            double bmi;
            bmi = Vikt / (Längd * Längd);
            return Math.Round(bmi, 1);  //Math.Round(vikt / (längd * längd),1);
        }

        public string GreetingMessage()
        {
            string message = "Hej jag heter " + Förnamn + " och jag mår bra";
            return message;
        }

        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }

    }

    
}
