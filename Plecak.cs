using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Plecak : Przedmiot
    {


        //public Plecak(string nazwa, string typ, int obrazenia) : base(nazwa, typ)
        //{
        //    nazwa = "Plecak";
        //    typ = "Plecak";
        //    obrazenia = 0;
        //}
        public Plecak(string nazwa, string typ) : base(nazwa, typ)
        {
            nazwa = "Plecak";
            typ = "Plecak";

        }
        public List<Przedmiot> ekwipunek = new List<Przedmiot>();
        public void DodajPrzedmiot(Przedmiot przedmiot)
        {
            if (ekwipunek.Count < 5) // Maksymalna ilość przedmiotów w plecaku to 5
            {
                ekwipunek.Add(przedmiot);
                Console.WriteLine("Przedmiot " + przedmiot.Nazwa + " dodany do plecaka.");
            }
            else
            {
                Console.WriteLine("Nie można dodać więcej przedmiotów do plecaka!");
            }
        }

        public void UsunPrzedmiot(Przedmiot przedmiot)
        {
            if (ekwipunek.Contains(przedmiot))
            {
                ekwipunek.Remove(przedmiot);
                Console.WriteLine("Przedmiot " + przedmiot.Nazwa + " usunięty z plecaka.");
            }
            else
            {
                Console.WriteLine("Nie można usunąć przedmiotu, który nie znajduje się w plecaku!");
            }
        }
    }
}
