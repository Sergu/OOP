using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators.EditingCreators
{
    public class BolidAtmoEditingCreator : BolidEditingCreator
    {
        public override Bolids.Bolid FactoryMethod(Bolids.Bolid bolid, List<string> fields)
        {
            BolidAtmo car = (BolidAtmo)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            fields.Add(car.nose);
            fields.Add(car.RearWing);
            fields.Add(car.DownForce);
            return car;
        }
    }
}
