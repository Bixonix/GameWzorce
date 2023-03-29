using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Miecz:Bron
    {
        public Miecz(string nazwa, string typ, int obrazenia) : base(nazwa,typ)
        {
            this.Obrazenia = obrazenia;
            typ = "Miecz";
        }
        public new static void WyswietlPrzedmioty(Miecz przedmiot)
        {
            Console.WriteLine("Nawa: " + przedmiot.Nazwa + " Typ: " + przedmiot.Typ + " Obrażenia: " + przedmiot.Obrazenia);
        }
    }
}
