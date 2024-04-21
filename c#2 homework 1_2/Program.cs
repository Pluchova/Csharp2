namespace c_2_homework_1_2
{
    internal class Program
    { /*
Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.
*/
        static void Main(string[] args)
        {
            Lucistnik Robin = new Lucistnik(10);

            while (Robin.PocetSipu >= 0)
            {
                Robin.Vystrel();

            }

            
        }
    }
}