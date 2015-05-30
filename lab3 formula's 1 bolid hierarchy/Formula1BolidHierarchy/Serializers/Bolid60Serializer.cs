using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializers
{
    public class Bolid60Serializer : BolidSerializer
    {
        public override string Serialize(Bolids.Bolid serializableBolid)
        {
            Bolids.Bolid bolid = serializableBolid as Bolid60;
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
