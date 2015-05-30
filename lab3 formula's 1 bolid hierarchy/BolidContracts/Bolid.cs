using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Bolids
{
    public abstract class Bolid
    {
        public string name { get; set; }
        public string engine { get; set; }
        public string body { get; set; }

        public abstract string ToString();
    }
}
