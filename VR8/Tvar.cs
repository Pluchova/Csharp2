using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR8
{
    public abstract class Tvar : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public virtual double VypocitejObsah()
        {
            throw new NotImplementedException();
        }

        public virtual double VypocitejObvod()
        {
            throw new NotImplementedException();
        }
    }
}
