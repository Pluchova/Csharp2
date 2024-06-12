using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR8
{
    internal class Obdelnik : Tvar 
    {
        public double a { get; set; }
        public double b { get; set; }

        public Obdelnik(double delka, double sire)
        {
            a = delka;
            b = sire;
        }

        public override double VypocitejObsah()
        {
            return a * b;
        }

        public override double VypocitejObvod()
        {
            return 2 * (a + b);
        }
    }
}
