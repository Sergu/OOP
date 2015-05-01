using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy
{
    public interface IBolid
    {
        string name { get; set; }
        string engine { get; set; }
        string body { get; set; }
        //public virtual string Serialize() { return null; }
        //void Deserialize();
    }
}
