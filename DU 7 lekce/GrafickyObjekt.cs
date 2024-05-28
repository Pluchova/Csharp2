using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU_7_lekce
{
    internal class GrafickyObjekt
    {
        
        public virtual void Vykreslit()
        {
            
            Console.WriteLine("X");
        }
        public string Barva { get; set; }

        public void NastavBarvu()
        {           
            Console.ForegroundColor = Enum.TryParse<ConsoleColor>(Barva, out ConsoleColor parsedBarva) ? parsedBarva : ConsoleColor.Gray;
        }

       public void ResetBarva()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
