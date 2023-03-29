using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Wojownik:Klasa
    {
        
        public Wojownik(string nazwa/*, int mana, int zycie*/)
        {
            this.Nazwa = nazwa;
            //this.Mana = mana;
            this.Profesja = "Wojownik";
            //this.Zycie = zycie;
            this.Mana = 0;
            this.Zycie = 200;
        }
        public static void Atack(Miecz miecz)
        {
            Atak_Fizyczny(miecz);
        }
        public static void Atak_Fizyczny(Miecz miecz)
        {
            Console.WriteLine("Atak fizyczny " + miecz.Obrazenia);
        }
        public void Wyswietl()
        {
            Console.WriteLine("Nick : " + Nazwa + ", Profesja : " + Profesja + ", Zycie: " + Zycie + ", Mana: " + Mana);
        }
    }
}
