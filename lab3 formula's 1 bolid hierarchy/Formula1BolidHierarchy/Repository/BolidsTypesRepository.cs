using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Repository
{
    public static class BolidsTypesRepository
    {
        private static List<Type> listOfDriversTypes = new List<Type>(){
            typeof(FirstBolid),
            typeof(Bolid60),
            typeof(BolidAtmo),
            typeof(BolidTurbo),
            typeof(Bolid80),
            typeof(NewBolid)
        };
        public static List<Type> ListOfDriversTypes { get { return listOfDriversTypes; } }
    }
}
