using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Bolids
{
    public class NewBolid : Bolid80
    {
        public string Kers{ get; set; }
        public string Drs { get; set; }
        public string Turbo { get; set; }
        public override string ToString()
        {
            return string.Format("Bolid: NewBolid");
        }
    }
}
