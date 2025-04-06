using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Pracownicy
{
    public class Pracownik
    {
        public string imie = "";
        public string stanowisko = "";
        public int wiek = 0;
        public string nazwisko = "";


        public Pracownik(string imie, string stanowisko, int wiek, string nazwisko)
        {
            this.imie = imie;
            this.stanowisko = stanowisko;
            this.wiek = wiek;
            this.nazwisko = nazwisko;
        }

        public Pracownik()
        {
            this.imie = "";
            this.stanowisko = "";
            this.wiek = 0;
            this.nazwisko = "";
        }

 
        public void DisplayInfo()
        {
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Wiek: " + wiek);
            Console.WriteLine("Stanowisko: " + stanowisko);
        }

    }
}
