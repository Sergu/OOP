using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy
{
    public abstract class BolidCreator
    {
        public abstract Bolid FactoryMethod(List<string> fields);
    }
}
