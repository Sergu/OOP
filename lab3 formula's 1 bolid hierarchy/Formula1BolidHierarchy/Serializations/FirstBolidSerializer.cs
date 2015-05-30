using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializations
{
    public class FirstBolidSerializer : IBolidSerializer
    {
        public Bolid bolid { get; set; }
        public FirstBolidSerializer(FirstBolid obj)
        {
            this.bolid = obj;
        }
        public string Serialize()
        {
            List<string> propertiesCollection = new List<string>();
            string str = "{";
            string strclass = "class:";
            string strname = "name:";
            string strengine = "engine:";
            string strbody = "body:";
            strclass = String.Concat(strclass, "FirstBolid;");
            strname = String.Concat(String.Concat(strname, bolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, bolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, bolid.body), ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
