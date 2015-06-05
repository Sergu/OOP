using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginContracts
{
    public interface ICryptPlugin
    {
        string EncCezar(string input);
        string DecCezar(string output);
    }
}
