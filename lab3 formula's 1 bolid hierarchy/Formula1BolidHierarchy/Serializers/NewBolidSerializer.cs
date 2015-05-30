using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializers
{
    public class NewBolidSerializer : BolidSerializer
    {
        public override string Serialize(Bolid serializableBolid)
        {
            List<string> propertiesCollection = new List<string>();
            string str = "{";
            string strclass = "class:";
            string strname = "name:";
            string strengine = "engine:";
            string strbody = "body:";
            string strNose = "nose:";
            string strRearWing = "rearwing:";
            string strDownForce = "downforce:";
            string strKers = "kers:";
            string strDrs = "drs:";
            string strTurbo = "turbo:";
            string strFrontWing = "frontwing:";
            strclass = String.Concat(strclass, "NewBolid;");
            strname = String.Concat(String.Concat(strname, serializableBolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, serializableBolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, serializableBolid.body), ";");
            strNose = string.Concat(strNose, (serializableBolid as NewBolid).nose, ";");
            strRearWing = String.Concat(strRearWing, (serializableBolid as NewBolid).RearWing, ";");
            strDownForce = String.Concat(strDownForce, (serializableBolid as NewBolid).DownForce, ";");
            strKers = String.Concat(strKers, (serializableBolid as NewBolid).Kers, ";");
            strDrs = String.Concat(strDrs, (serializableBolid as NewBolid).Drs, ";");
            strTurbo = String.Concat(strTurbo, (serializableBolid as NewBolid).Turbo, ";");
            strFrontWing = String.Concat(strFrontWing, (serializableBolid as NewBolid).FrontWing, ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add(strNose);
            propertiesCollection.Add(strRearWing);
            propertiesCollection.Add(strDownForce);
            propertiesCollection.Add(strFrontWing);
            propertiesCollection.Add(strKers);
            propertiesCollection.Add(strDrs);
            propertiesCollection.Add(strTurbo);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
