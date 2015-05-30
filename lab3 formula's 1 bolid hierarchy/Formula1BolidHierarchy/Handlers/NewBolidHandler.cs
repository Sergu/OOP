using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Handlers
{
    public class NewBolidHandler : HandlerFromFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "Nose", "Rearwing", "Downforce", "Frontwing","Turbo","Kers","Drs" }; }
        }
    }
}
