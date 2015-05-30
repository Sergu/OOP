using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Factory.BolidDeserializerCreators;

namespace Formula1BolidHierarchy.Repository
{
    public static class BolidDeserializerRepository
    {
        private static List<BolidDeserializerCreator> bolid = new List<BolidDeserializerCreator>
        {
            new FirstBolidDeserializerCreator(),
            new Bolid60DeserializerCreator(),
            new BolidAtmoDeserializerCreator(),
            new BolidTurboDeserializerCreator(),
            new Bolid80DeserializerCreator(),
            new NewBolidDeserializerCreator()
        };
        public static List<BolidDeserializerCreator> Bolid
        {
            get {return bolid;}
            set {bolid = value;}
        }

    }
}
