using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU_7_lekce
{
    internal class Text : GrafickyObjekt
    {       
        public string VypsanyText { get; set; }
        public override void Vykreslit()
        {
            NastavBarvu();
            Console.WriteLine(VypsanyText);
            ResetBarva();
        }

    }
}
