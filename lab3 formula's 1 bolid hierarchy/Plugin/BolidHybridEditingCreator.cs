using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;
using Formula1BolidHierarchy.Bolids;

namespace Plugin
{
    public class BolidHybridEditingCreator : BolidEditingCreator
    {
        public override Formula1BolidHierarchy.Bolids.Bolid FactoryMethod(Formula1BolidHierarchy.Bolids.Bolid bolid, List<string> fields)
        {
            BolidHybrid car = (BolidHybrid)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            fields.Add(car.Turbo);
            fields.Add(car.Wheels);
            return car;
        }
    }
}
