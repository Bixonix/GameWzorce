using System;

namespace GameWzorce
{
    class GameWzorce
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("Witaj w Grze przygotowanej na potrzeby zadania nr 1 z wzorców projektowych");
            Console.WriteLine("Wybierz co chciałbyć zrobić 1 - stwórz postać");
            while(true)
            { 
                try
                {
                  menu = int.Parse(Console.ReadLine());
                    if(menu == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                    continue;
                }
               catch(FormatException)
               {
                  Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                   continue;
               }
            }
            if (menu == 1)
            {
                Console.WriteLine("Tworzenie nowej postaci");
                Console.WriteLine("Podaj nick: ");
                string tmpNick = Console.ReadLine();
                Console.WriteLine("Wybierz profesje 1 - Wojownik 2 - Mag");
                int tmpKlasa;
                while (true)
                {
                    try
                    {
                        tmpKlasa = int.Parse(Console.ReadLine());
                        if (0 < tmpKlasa && tmpKlasa < 3)
                        {
                            break;
                        }
                        else
                            Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                        continue;
                    }
                }
                if (tmpKlasa == 1)
                {
                    Wojownik wojownik = new Wojownik(tmpNick);
                    Console.WriteLine("Utworzyłeś postać: ");
                    wojownik.Wyswietl();
                    Przedmiot[] ekwipunek = new Przedmiot[3];
                    Console.WriteLine("Do twojego ekwipunku dodano plecak");
                    ekwipunek[0] = new Plecak("plecak", "plecak");
                    Console.WriteLine("Do twojego ekwipunku dodano miecz");
                    ekwipunek[1] = new Miecz("miecz", "miecz",100);
                    Console.WriteLine("Do twojego ekwipunku dodano miecz");
                    ekwipunek[2] = new Miecz("Wielki miecz", "miecz", 200);
                    Console.WriteLine("Twój ekipunek to: ");
                    for (int i = 0; i < ekwipunek.Length; i++)
                    {
                        if (ekwipunek[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if ( i == 0 )
                            {
                                Przedmiot.WyswietlPrzedmioty(ekwipunek[i]);
                            }
                            else
                            {
                                Miecz.WyswietlPrzedmioty((Miecz)(Bron)ekwipunek[i]);
                            }
                        }

                    }
                    Console.WriteLine("Wybierz przedmiot, który chcesz wyrzucić: 1 - miecz 2 - Wielki miecz");
                    int tmpUsun;
                    while (true)
                    {
                        try
                        {
                            tmpUsun = int.Parse(Console.ReadLine());
                            if (0 < tmpUsun && tmpUsun < 3)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                    }
                    ekwipunek[tmpUsun] = null;
                    Console.WriteLine("Twój ekipunek to: ");
                    for (int i = 0; i < ekwipunek.Length; i++)
                    {
                        if (ekwipunek[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Przedmiot.WyswietlPrzedmioty(ekwipunek[i]);
                            }
                            else
                            {
                                Miecz.WyswietlPrzedmioty((Miecz)(Bron)ekwipunek[i]);
                            }
                        }

                    }
                    Console.WriteLine("Jeśli chcesz zaatakować naciśnij 1");
                    int tmpAttack;
                    while (true)
                    {
                        try
                        {
                            tmpAttack = int.Parse(Console.ReadLine());
                            if (1 == tmpAttack)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                    }
                    if (ekwipunek[1] != null)
                    {
                        Wojownik.Atack((Miecz)(Bron)ekwipunek[1]);
                    }
                    else
                    {
                        Wojownik.Atack((Miecz)(Bron)ekwipunek[2]);
                    }
                }
                else
                {
                    Mag mag = new Mag(tmpNick);
                    Console.WriteLine("Utworzyłeś postać: ");
                    mag.Wyswietl();
                    Przedmiot[] ekwipunek = new Przedmiot[3];
                    Console.WriteLine("Do twojego ekwipunku dodano plecak");
                    ekwipunek[0] = new Plecak("plecak", "plecak");
                    Console.WriteLine("Do twojego ekwipunku dodano rozdzka");
                    ekwipunek[1] = new Rozdzka("rodzka", "rozdzka", 50);
                    Console.WriteLine("Do twojego ekwipunku dodano Duza rozdzka");
                    ekwipunek[2] = new Rozdzka("rodzka", "rozdzka", 150);
                    Console.WriteLine("Twój ekipunek to: ");
                    for (int i = 0; i < ekwipunek.Length; i++)
                    {
                        if (ekwipunek[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Przedmiot.WyswietlPrzedmioty(ekwipunek[i]);
                            }
                            else
                            {
                                Rozdzka.WyswietlPrzedmioty((Rozdzka)(Bron)ekwipunek[i]);
                            }
                        }

                    }
                    Console.WriteLine("Wybierz przedmiot, który chcesz wyrzucić: 1 - rozdzka 2 - Duza rozdzka");
                    int tmpUsun;
                    while (true)
                    {
                        try
                        {
                            tmpUsun = int.Parse(Console.ReadLine());
                            if (0 < tmpUsun && tmpUsun < 3)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                    }
                    ekwipunek[tmpUsun] = null;
                    Console.WriteLine("Twój ekipunek to: ");
                    for (int i = 0; i < ekwipunek.Length; i++)
                    {
                        if (ekwipunek[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Przedmiot.WyswietlPrzedmioty(ekwipunek[i]);
                            }
                            else
                            {
                                Rozdzka.WyswietlPrzedmioty((Rozdzka)(Bron)ekwipunek[i]);
                            }
                        }

                    }
                    Console.WriteLine("Jeśli chcesz zaatakować naciśnij 1");
                    int tmpAttack;
                    while (true)
                    {
                        try
                        {
                            tmpAttack = int.Parse(Console.ReadLine());
                            if (1 == tmpAttack)
                            {    
                                break;
                            }
                            else
                                Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wpisałeś niedozwoloną wartość, spróbuj ponownie");
                            continue;
                        }
                    }
                    if(ekwipunek[1] != null)
                    {
                        Mag.Atack((Rozdzka)(Bron)ekwipunek[1]);
                    }
                    else
                    {
                        Mag.Atack((Rozdzka)(Bron)ekwipunek[2]);
                    }


                }
            }
            else { }


        }
    }
}
