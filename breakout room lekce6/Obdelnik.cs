using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakout_room_lekce6
{
    internal class Obdelnik
    {
        private double _sirka;
        private double _vyska;

        public Obdelnik(double sirka, double vyska)
        {
            _sirka = sirka;
            _vyska = vyska;

        }

        public Obdelnik(double delkaStrany) : this(delkaStrany, delkaStrany)
        {

        }

        public void VypisInformace()
        {
            Console.WriteLine($"Šířka je {_sirka}, výška je {_vyska}.");
        }
    }
}
