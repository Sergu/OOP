using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace Plugin
{
    public class BolidHybridCreator : BolidCreator
    {
        public override Formula1BolidHierarchy.Bolids.Bolid FactoryMethod(List<string> fields)
        {
            BolidHybrid bolid = new BolidHybrid();
            bolid.name = fields[0];
            bolid.engine = fields[1];
            bolid.body = fields[2];
            bolid.Wheels = fields[3];
            bolid.Turbo = fields[4];
            return bolid;
        }
    }
}
