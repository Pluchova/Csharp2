using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2_homework_1_2
{
    internal class Lucistnik
    {
        public int PocetSipu;
        public Lucistnik(int pocetSipu)
        {
            PocetSipu = pocetSipu;
        }
        public void Vystrel()
        {
            if (PocetSipu > 0)
            {
                Console.WriteLine("Vzdy se strefim primo do prostred!");
                PocetSipu--;
            }
            else
            {
                Console.WriteLine("Nemam sipy");
            }
        }
    }
}
