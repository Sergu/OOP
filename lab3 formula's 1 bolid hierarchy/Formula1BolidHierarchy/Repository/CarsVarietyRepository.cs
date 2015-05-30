using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy.Repository
{
    public static class CarsVarietyRepository
    {
        private static List<object> listCars = new List<object>()
        {
            "FirstBolid","Bolid60","BolidAtmo","BolidTurbo","Bolid80","NewBolid"
        };

        public static List<object> ListCars
        {
            get { return listCars; }
            set { listCars = value; }   
        }
    }
}
