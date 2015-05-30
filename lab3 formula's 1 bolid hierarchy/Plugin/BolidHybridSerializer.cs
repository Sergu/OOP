using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace Plugin
{
    public class BolidHybridSerializer : BolidSerializer
    {
        public override string Serialize(Formula1BolidHierarchy.Bolids.Bolid serializableBolid)
        {
            List<string> propertiesCollection = new List<string>();
            string str = "{";
            string strclass = "class:";
            string strname = "name:";
            string strengine = "engine:";
            string strbody = "body:";
            string strWheels = "wheels:";
            string strTurbo = "turbo:";
            strclass = String.Concat(strclass, "BolidHybrid;");
            strname = String.Concat(String.Concat(strname, serializableBolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, serializableBolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, serializableBolid.body), ";");
            strTurbo = string.Concat(strTurbo, (serializableBolid as BolidHybrid).Turbo, ";");
            strWheels = String.Concat(strWheels, (serializableBolid as BolidHybrid).Wheels, ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add(strWheels);
            propertiesCollection.Add(strTurbo);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
