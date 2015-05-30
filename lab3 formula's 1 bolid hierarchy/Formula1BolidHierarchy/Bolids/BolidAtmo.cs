using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Bolids
{
    public class BolidAtmo : Bolid60
    {
        public string RearWing { get; set; }
        public string DownForce { get; set; }
        public override string ToString()
        {
            return string.Format("Bolid: BolidAtmo");
        }
    }
}
