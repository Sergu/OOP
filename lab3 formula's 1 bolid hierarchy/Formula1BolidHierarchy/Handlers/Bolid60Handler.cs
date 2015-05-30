using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Handlers
{
    public class Bolid60Handler : HandlerFromFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "Nose" }; }
        }
    }
}
