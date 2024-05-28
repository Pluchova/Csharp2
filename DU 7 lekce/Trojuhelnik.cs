using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU_7_lekce
{
    internal class Trojuhelnik : GrafickyObjekt
    {
        public int Vyska { get; set; }

        public override void Vykreslit()
        {
            NastavBarvu();
            for (int i = 1; i <= Vyska; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            ResetBarva();
        }
        }
       
}
