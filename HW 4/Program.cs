namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            DateTime aktualni = DateTime.Now;
            Console.WriteLine("Aktuální datum a čas: " + aktualni);
            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            DateTime datumNarozeni = new DateTime(1998, 03, 25);
            Console.WriteLine($"Narodila jsem se před {(aktualni - datumNarozeni).Days} dny");
            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> pipety = new List<string>()
        {
            "Eppendorf",
            "Finnpipette",
            "Transferpette",
            "Nichipet",
            "Socorex"
        };
            // 4. Smaž z tohoto listu libovolnou hodnotu.
            Console.WriteLine(pipety.Contains("Nichipet"));
            pipety.Remove("Nichipet");
            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            Console.WriteLine(pipety.Contains("Nichipet"));
            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.WriteLine($"Pipet máme: {pipety.Count}");
            for (int i = 0; i < pipety.Count; i++)
            {
                Console.WriteLine($"{pipety[i]}");
            }

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> nakupniKosik = new Dictionary<string, int>()
        {
            {
                "chleba",
                32
            },
            {
                "vejce",
                25
            },
            {
                "šunka",
                22
            }
        };
            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            string hledanaPolozka = "šunka";
            if (nakupniKosik.ContainsKey(hledanaPolozka))
            {
                int cena = nakupniKosik[hledanaPolozka];
                Console.WriteLine($"V nákupním košíku se položka {hledanaPolozka} nachází a stojí {cena} Kč.");
            }
            else
            {
                Console.WriteLine("V košíku tato položka není");
            }

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            KeyValuePair<string, int> chleba = new KeyValuePair<string, int>("chleba", 32);
            if (nakupniKosik.ContainsKey(chleba.Key))
            {
                nakupniKosik[chleba.Key] += chleba.Value;
            }
            else
            {
                nakupniKosik.Add(chleba.Key, chleba.Value);
            }

            Console.WriteLine("Obsah nákupního košíku: ");
            foreach (var polozka in nakupniKosik)
            {
                Console.WriteLine($"Položka: {polozka.Key}, Cena: {polozka.Value} Kč");
            }
        }
    }
}