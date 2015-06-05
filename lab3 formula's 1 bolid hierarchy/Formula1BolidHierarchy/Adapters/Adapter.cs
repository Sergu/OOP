using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeignPlugContracts;

namespace Formula1BolidHierarchy.Adapters
{
    public class Adapter : ITarget
    {
        IControlSum PluginClass;
        public Adapter(IControlSum plugin)
        {
            this.PluginClass = plugin;
        }

        public string SumFile(string path)
        {
            return PluginClass.SumFile(path);
        }
    }
}
