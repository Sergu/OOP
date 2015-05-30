using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Plugin
{
    public class BolidHybrid : Bolid
    {
        public string Turbo { get; set; }
        public string Wheels { get; set; }

        public override string ToString()
        {
            return string.Format("Bolid: BolidHybrid");
        }
    }
}
