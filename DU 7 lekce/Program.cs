namespace DU_7_lekce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GrafickyObjekt> objekty = new List<GrafickyObjekt>
            {   new GrafickyObjekt(),
                new Obdelnik { Sirka = 3, Vyska = 2, Barva = "Red" },
                new Trojuhelnik { Vyska = 3, Barva ="Green" },
                new Text { VypsanyText = "Ahoj", Barva ="Magenta" }
            };

            foreach (var objekt in objekty)
            {
                objekt.Vykreslit();
                Console.WriteLine();
            }
        }
    }
}