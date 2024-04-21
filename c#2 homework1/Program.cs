namespace c_2_ukol1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
            Console.WriteLine("Napiš první sčítanec");
            string scitanec1 = Console.ReadLine();
            double scitanec1Parse;
            bool jeCislo = double.TryParse(scitanec1, out scitanec1Parse);
            while (!jeCislo)
            {
                Console.WriteLine("Toto není číslo");
                scitanec1 = Console.ReadLine();
                jeCislo = double.TryParse(scitanec1, out scitanec1Parse);
            }
            Console.WriteLine("Napiš druhý sčítanec");
            string scitanec2 = Console.ReadLine();
            double scitanec2Parse;
            bool jeCislo2 = double.TryParse(scitanec2, out scitanec2Parse);
            while (!jeCislo2)
            {
                Console.WriteLine("Toto není číslo");
                scitanec2 = Console.ReadLine();
                jeCislo2 = double.TryParse(scitanec2, out scitanec2Parse);
            }

            Console.WriteLine($"Součet čísel {scitanec1Parse} + {scitanec2Parse} = {scitanec1Parse + scitanec2Parse}");

            //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.

            Console.WriteLine("Kolik hvězdiček mám vypsat?");
            string pocetHvezd = Console.ReadLine();
            int pocetHvezdParse;
            bool jeCisloHvezd = int.TryParse(pocetHvezd, out pocetHvezdParse);
            while (!jeCisloHvezd)
            {
                Console.WriteLine("Špatný formát vstupu, zadej celé číslo");
                pocetHvezd = Console.ReadLine();
                jeCisloHvezd = int.TryParse(pocetHvezd, out pocetHvezdParse);
            }

            for (int i = 0; i < pocetHvezdParse; i++)
            {
               Console.Write("*");
            }
            
              
            

        }
    }
}