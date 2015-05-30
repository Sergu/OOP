using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Handlers;

namespace Formula1BolidHierarchy.Repository
{
    public static class HandlersRepository
    {
        private static List<HandlerFromFields> listOfHandlers = new List<HandlerFromFields>()
        {
            new FirstBolidHandler(),
            new Bolid60Handler(),
            new BolidAtmoHandler(),
            new BolidTurboHandler(),
            new Bolid80Handler(),
            new NewBolidHandler()
        };
        public static List<HandlerFromFields> ListOfHandlers
        {
            get { return listOfHandlers; }
        }
    }
}
