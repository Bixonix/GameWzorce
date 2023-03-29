using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    
    class Rozdzka : Bron
    {
        public Rozdzka(string nazwa, string typ, int obrazenia) : base(nazwa, typ)
        {
            this.Obrazenia = obrazenia;
            typ = "Rozdzka";
        }
        public static void WyswietlPrzedmioty(Rozdzka przedmiot)
        {
            Console.WriteLine("Nawa: " + przedmiot.Nazwa + " Typ: " + przedmiot.Typ + " Obrażenia: " + przedmiot.Obrazenia);
        }
        

    }
}
