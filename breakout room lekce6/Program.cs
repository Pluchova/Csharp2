namespace breakout_room_lekce6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obdelnik obdelnik1 = new Obdelnik(4, 3);
            obdelnik1.VypisInformace();

            Obdelnik obdelnik2 = new Obdelnik(5);
            obdelnik2.VypisInformace();
        }
    }
}