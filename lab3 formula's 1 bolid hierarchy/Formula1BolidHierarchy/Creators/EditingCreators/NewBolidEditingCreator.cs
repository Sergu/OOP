using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators.EditingCreators
{
    public class NewBolidEditingCreator : BolidEditingCreator
    {
        public override Bolid FactoryMethod(Bolid bolid, List<string> fields)
        {
            NewBolid car = (NewBolid)bolid;
            fields.Add(car.name);
            fields.Add(car.engine);
            fields.Add(car.body);
            fields.Add(car.nose);
            fields.Add(car.RearWing);
            fields.Add(car.DownForce);
            fields.Add(car.FrontWing);
            fields.Add(car.Turbo);
            fields.Add(car.Kers);
            fields.Add(car.Drs);
            return car;
        }
    }
}
