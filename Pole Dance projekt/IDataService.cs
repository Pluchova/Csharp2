using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_Dance_projekt
{
    public interface IDataService
    {
        IEnumerable<string> GetPrvky(string obtiznost, bool includeInverted);
        IEnumerable<string> GetObtiznosti();
    }
}

