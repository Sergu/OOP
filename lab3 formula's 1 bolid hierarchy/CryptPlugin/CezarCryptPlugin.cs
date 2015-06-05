using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginContracts;

namespace CryptPlugin
{
    public class CezarCryptPlugin : ICryptPlugin
    {
        public string EncCezar(string input)
        {
            string str=string.Empty;
            for (int i = 0;i<input.Length;i++)
            {
                str += Convert.ToChar((int)(input[i]) + 3);
            }
            return str;
        }
        public string DecCezar(string output)
        {
            string str = string.Empty;
            for (int i = 0; i < output.Length; i++)
            {
                str += Convert.ToChar((int)(output[i]) - 3);
            }
            return str;
        }
    }
}
