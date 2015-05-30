using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace Plugin
{
    public class BolidHybridSerializerCreator : BolidSerializerCreator
    {
        public override BolidSerializer FactoryMethod()
        {
            return new BolidHybridSerializer();
        }
    }
}
