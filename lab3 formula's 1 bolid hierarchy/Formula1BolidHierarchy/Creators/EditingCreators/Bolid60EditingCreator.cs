using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators.EditingCreators
{
    public class Bolid60EditingCreator : BolidEditingCreator
    {
        public override Bolid FactoryMethod(Bolid bolid, List<string> fields)
        {
            Bolid60 car = (Bolid60)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            fields.Add(car.nose);
            return car;
        }
    }
}
