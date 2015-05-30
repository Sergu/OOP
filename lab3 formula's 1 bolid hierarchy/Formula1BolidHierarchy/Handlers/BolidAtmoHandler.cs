using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Handlers
{
    public class BolidAtmoHandler : HandlerFromFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "Nose","Rearwing","Downforce"} ;}
        }
    }
}
