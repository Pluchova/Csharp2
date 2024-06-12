using System.Collections.Generic;
using System.Diagnostics;

namespace BR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };
            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);

             static void Vypis(List<double> cisla)
            {
                Console.WriteLine("Čísla v seznamu: ");
                foreach (double item in cisla)
                {
                    Console.WriteLine(item);
                }
            }
            // Vypis na konzoli pocet cisel v seznamu
           VypisPocet(cisla);
// Pridej cislo 0.5 do seznamu

            static void VypisPocet(List<double> cisla)
            {
                Console.WriteLine($"Počet čísel v seznamu: {cisla.Count}");
            }

            Console.WriteLine($"Do seznamu je přidáno číslo 0,5");

            cisla.Add(0.5);

            
            
            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            foreach(double c in cisla)
            {
                if (c>0.8)
                {
                    Console.WriteLine($"První číslo větší než 0,8 je {c}");
                    break;
                }
            }

            //cisla.First(x => x > 0.8);

            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu

            double max = cisla.Max();
            Console.WriteLine($"Největší číslo je: {max} na pozici {cisla.IndexOf(max)}.");
            cisla.Remove(max);
            Vypis(cisla);
            VypisPocet(cisla);
            // vypis opet vsechna cisla a jejich pocet
            cisla.RemoveAt(5);
            Vypis(cisla);
            /*  Vytvorte tridu TelefonniSeznam
  - uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
  - k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
  - v ramci konstruktoru vyplnte nekolik jmen a cisel
  - vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
  - vytvorte metodu, ktera vrati telefonni cislo cloveka
  - vytvorte metodu, ktera vypise cely telefonni seznam
  - vytvorte metodu, ktera smaze daneho cloveka
  -vytvorte metodu, ktera smaze cely telefonni seznam.Clear()
  - myslete na mozne chybove stavy(co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
  -napiste kratky program, ktery overi funkcnost teto tridy*/
            using System;
            using System.Collections.Generic;

class TelefonniSeznam
        {
            private Dictionary<string, int> seznam;

            public TelefonniSeznam()
            {
                seznam = new Dictionary<string, int>()
        {
            {"Alice", 123456789},
            {"Bob", 987654321},
            {"Charlie", 456123789}
        };
            }

            public void PridejOsobu(string jmeno, int telefonniCislo)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    Console.WriteLine($"Osoba se jménem {jmeno} již existuje v seznamu.");
                }
                else
                {
                    seznam.Add(jmeno, telefonniCislo);
                    Console.WriteLine($"Osoba se jménem {jmeno} byla přidána do seznamu s telefonním číslem {telefonniCislo}.");
                }
            }

            public int NajdiTelefon(string jmeno)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    return seznam[jmeno];
                }
                else
                {
                    Console.WriteLine($"Osoba se jménem {jmeno} nenalezena v seznamu.");
                    return -1; // Vrací -1 pro označení chyby.
                }
            }

            public void VypisSeznam()
            {
                Console.WriteLine("Telefonní seznam:");
                foreach (var polozka in seznam)
                {
                    Console.WriteLine($"{polozka.Key}: {polozka.Value}");
                }
            }

            public void SmazOsobu(string jmeno)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    seznam.Remove(jmeno);
                    Console.WriteLine($"Osoba se jménem {jmeno} byla odstraněna ze seznamu.");
                }
                else
                {
                    Console.WriteLine($"Osoba se jménem {jmeno} nenalezena v seznamu.");
                }
            }

            public void SmazSeznam()
            {
                seznam.Clear();
                Console.WriteLine("Telefonní seznam byl vymazán.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                TelefonniSeznam seznam = new TelefonniSeznam();

                // Testování funkcionality třídy
                seznam.VypisSeznam();
                seznam.PridejOsobu("David", 654321987);
                seznam.VypisSeznam();
                Console.WriteLine($"Telefonní číslo pro Alice: {seznam.NajdiTelefon("Alice")}");
                Console.WriteLine($"Telefonní číslo pro Eva: {seznam.NajdiTelefon("Eva")}");
                seznam.SmazOsobu("Bob");
                seznam.VypisSeznam();
                seznam.SmazSeznam();
                seznam.VypisSeznam(); // Zkontroluje, zda je seznam prázdný
            }
        }

    }
    }
}