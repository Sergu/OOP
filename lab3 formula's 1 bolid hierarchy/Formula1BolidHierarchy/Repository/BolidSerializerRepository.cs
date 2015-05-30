using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Factory.BolidSerializerCreators;

namespace Formula1BolidHierarchy.Repository
{
    public static class BolidSerializerRepository
    {
        private static List<BolidSerializerCreator> bolids = new List<BolidSerializerCreator>()
        {
            new FirstBolidSerializerCreator(),
            new Bolid60SerializerCreator(),
            new BolidAtmoSerializerCreator(),
            new BolidTurboSerializerCreator(),
            new Bolid80SerializerCreator(),
            new NewBolidSerializerCreator()
        };
        public static List<BolidSerializerCreator> Bolids
        {
            get {return bolids;}
            set {bolids = value;}
        }
    }
}
