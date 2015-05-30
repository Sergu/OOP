using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators.EditingCreators
{
    public class FirstBolidEditingCreator : BolidEditingCreator
    {
        public override Bolids.Bolid FactoryMethod(Bolids.Bolid bolid, List<string> fields)
        {
            FirstBolid car = (FirstBolid)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            return car;
        }
    }
}
