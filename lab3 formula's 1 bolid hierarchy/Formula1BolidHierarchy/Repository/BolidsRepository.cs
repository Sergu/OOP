using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Repository
{
    public class BolidsRepository
    {
        private List<Bolid> bolid = new List<Bolid>();
        public List<Bolid> Bolid 
        {
            get { return bolid; } 
            set { bolid = value; }
        }
    }
}
