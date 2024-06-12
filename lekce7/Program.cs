namespace lekce7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hrdina pavel = new Hrdina();
            pavel.Jmeno = "Pavel";
            pavel.JakSeJmenuji();
            pavel.Zivoty = 11;
            PohadkovaBytost bytostObecna = new PohadkovaBytost();
            bytostObecna.Jmeno = "bytostObecna";

            Carodejnice bilaPani = new Carodejnice() { Jmeno = "bilaPani" };

            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost>();
            pohadkoveBytosti.Add(pavel);
            pohadkoveBytosti.Add(bytostObecna);

            pohadkoveBytosti.ForEach(x => x.JakSeJmenuji());

        }
    }

    public class PohadkovaBytost
    {
        public string Jmeno { get; set; }
        public void JakSeJmenuji()
        {
            Console.WriteLine(Jmeno);

        }

    }
    public class Hrdina : PohadkovaBytost
    {
        public int Zivoty { get; set; } = 10;
    }

    public class Carodejnice : PohadkovaBytost
    {

    }
}