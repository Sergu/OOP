using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators.EditingCreators
{
    public class Bolid80EditingCreator : BolidEditingCreator
    {
        public override Bolid FactoryMethod(Bolid bolid, List<string> fields)
        {
            Bolid80 car = (Bolid80)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            fields.Add(car.nose);
            fields.Add(car.RearWing);
            fields.Add(car.DownForce);
            fields.Add(car.FrontWing);
            return car;
        }
    }
}
