using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializations
{
    public interface IBolidSerializer
    {
        Bolid bolid { get; set; }
        string Serialize();
    }
}
