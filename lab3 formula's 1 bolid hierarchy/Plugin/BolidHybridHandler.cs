using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace Plugin
{
    class BolidHybridHandler : HandlerFromFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "Turbo", "Number of pairs of wheels" }; }
        }
    }
}
