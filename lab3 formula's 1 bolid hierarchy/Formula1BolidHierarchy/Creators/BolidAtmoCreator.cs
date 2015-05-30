using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators
{
    public class BolidAtmoCreator : BolidCreator
    {
        public override Bolids.Bolid FactoryMethod(List<string> fields)
        {
            BolidAtmo bolid = new BolidAtmo();
            bolid.name = fields[0];
            bolid.engine = fields[1];
            bolid.body = fields[2];
            bolid.nose = fields[3];
            bolid.RearWing = fields[4];
            bolid.DownForce = fields[5];
            return bolid;
        }
    }
}
