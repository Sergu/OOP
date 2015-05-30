using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators
{
    public class FirstBolidCreator : BolidCreator
    {
        public override Bolid FactoryMethod(List<string> fields)
        {
            FirstBolid bolid = new FirstBolid();
            bolid.name = fields[0];
            bolid.engine = fields[1];
            bolid.body = fields[2];
            return bolid;
        }
    }
}
