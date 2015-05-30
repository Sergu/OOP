using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializations
{
    class Bolid60Serializer : IBolidSerializer
    {
        public Bolid bolid { get; set; }
        public Bolid60Serializer(Bolid60 obj)
        {
            this.bolid = obj;
        }
        public string Serialize()
        {
            bolid = bolid as Bolid60;
            List<string> propertiesCollection = new List<string>();
            string str = "{";
            string strclass = "class:";
            string strname = "name:";
            string strengine = "engine:";
            string strbody = "body:";
            string strnose = "nose:";
            strclass = String.Concat(strclass, "Bolid60;");
            strname = String.Concat(String.Concat(strname,bolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, bolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, bolid.body), ";");
            strnose = String.Concat(strnose, (bolid as Bolid60).nose, ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add(strnose);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
