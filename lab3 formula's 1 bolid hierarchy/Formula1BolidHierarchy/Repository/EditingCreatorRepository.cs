using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Creators.EditingCreators;

namespace Formula1BolidHierarchy.Repository
{
    public static class EditingCreatorRepository
    {
        private static List<BolidEditingCreator> list = new List<BolidEditingCreator>()
        {
            new FirstBolidEditingCreator(),
            new Bolid60EditingCreator(),
            new BolidAtmoEditingCreator(),
            new BolidTurboEditingCreator(),
            new Bolid80EditingCreator(),
            new  NewBolidEditingCreator(),
        };
        public static List<BolidEditingCreator> ListOfEditingCreators
        {
            get { return list;}
        }
    }
}
