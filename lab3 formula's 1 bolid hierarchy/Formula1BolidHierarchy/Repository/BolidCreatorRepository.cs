using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Creators;

namespace Formula1BolidHierarchy.Repository
{
    public static class BolidCreatorRepository
    {
        private static List<BolidCreator> listBolidCreators = new List<BolidCreator>()
        {
            new FirstBolidCreator(),
            new Bolid60Creator(),
            new BolidAtmoCreator(),
            new BolidTurboCreator(),
            new Bolid80Creator(),
            new NewBolidCreator()
        };
        public static List<BolidCreator> ListBolidCreators
        {
            get { return listBolidCreators; }
            set { listBolidCreators = value; }
        }
    }
}
