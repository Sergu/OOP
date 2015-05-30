using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace Plugin
{
    public class BolidHybridDeserializerCreator : BolidDeserializerCreator
    {
        public override BolidDeserializer FactoryMethod()
        {
            return new BolidHybridDeserializer();
        }
    }
}
