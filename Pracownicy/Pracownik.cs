using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pracownicy
{
    public class Pracownik
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek { get; set; }
        public string stanowisko { get; set; }
        public Pracownik()
        {
            imie = "";
            nazwisko = "";
            wiek = 0;
            stanowisko = "";
        }

        // Konstruktor z parametrami
        public Pracownik(string imie, string nazwisko, int wiek, string stanowisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.stanowisko = stanowisko;
        }


    };
}
