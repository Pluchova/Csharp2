namespace VR8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carodejnice minerva = new Carodejnice();
            Rytir drson = new Rytir();
            Princezna zlatovlaska = new Princezna();

            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost> { minerva, drson, zlatovlaska };

            foreach (PohadkovaBytost bytost in pohadkoveBytosti)
            {
                bytost.NapisJakTravisVolnyCas();
            }



            var mojeTvary = new List<Tvar>()
            { new Obdelnik(2,3),
              new Kruh(4)
            };

            foreach (var tvar in mojeTvary)
            {
                Console.WriteLine(tvar.VypocitejObsah());
                Console.WriteLine(tvar.VypocitejObvod());

            }
        }
    }
}