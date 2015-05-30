using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Creators
{
    public class Bolid60Creator : BolidCreator
    {
        public override Bolid FactoryMethod(List<string> fields)
        {
            Bolid60 bolid = new Bolid60();
            bolid.name = fields[0];
            bolid.engine = fields[1];
            bolid.body = fields[2];
            bolid.nose = fields[3];
            return bolid;
        }
    }
}
