using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR8
{
    internal class Kruh : Tvar 
    {   
        public double Polomer { get; set; }

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }
        public override double VypocitejObsah()
        {
            return Math.PI * Polomer * Polomer;

        }

        public override double VypocitejObvod()
        {
            return 2 * Math.PI * Polomer;
        }
    }
}
