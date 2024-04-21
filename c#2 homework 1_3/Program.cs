namespace c_2_homework_1_3
{
    internal class Program
    {  public static int ZkontrolujVstup(string hadaneCislo)
        {
            int hadaneCisloParse;
            bool jeCislo = int.TryParse(hadaneCislo, out hadaneCisloParse);

            while (!jeCislo || hadaneCisloParse < 1 || hadaneCisloParse > 10)
            {
                Console.WriteLine("Zadaný vstup není platný. Zadej celé číslo mezi 1 a 10:");
                hadaneCislo = Console.ReadLine();
                jeCislo = int.TryParse(hadaneCislo, out hadaneCisloParse);
            }
            return hadaneCisloParse;
        }

        /*Napište program, který umožní hádat číslo.Zeptá se, jaké číslo si myslím.Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
       Např.
       Hádej číslo: 10
       Číslo je menší, hádej znovu: 5
       Číslo je větší, hádej znovu: 7
       To je správně!*/

        static void Main(string[] args)
        {
            Random generator = new Random();
            int nahodneCislo = generator.Next(1, 11);

            Console.WriteLine("Myslím si číslo od 1 do 10, hádej!");

            string hadaneCislo = Console.ReadLine();
            int hadaneCisloParse = ZkontrolujVstup(hadaneCislo);
           

            while (hadaneCisloParse != nahodneCislo)
            {
                if (hadaneCisloParse > nahodneCislo)
                {
                    Console.WriteLine($"Číslo je menší, hádej znovu: ");
                }
                else if (hadaneCisloParse < nahodneCislo)
                {
                    Console.WriteLine($"Číslo je větší, hádej znovu: ");
                }

                hadaneCislo = Console.ReadLine();
                hadaneCisloParse = ZkontrolujVstup(hadaneCislo);
            }

            Console.WriteLine("To je správně! Hádané číslo je " + hadaneCisloParse);
        }
    }
}