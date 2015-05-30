using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializations
{
    public class BolidTurboSerializer:IBolidSerializer
    {
        public Bolid bolid { get; set; }
        public BolidTurboSerializer(BolidTurbo obj)
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
            string strNose = "nose:";
            string strRearWing = "rearwing:";
            string strDownForce = "downforce:";
            string strTurbo = "turbo:";
            strclass = String.Concat(strclass, "BolidTurbo;");
            strname = String.Concat(String.Concat(strname, bolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, bolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, bolid.body), ";");
            strNose = string.Concat(strNose, (bolid as BolidTurbo).nose, ";");
            strRearWing = String.Concat(strRearWing, (bolid as BolidTurbo).RearWing, ";");
            strDownForce = String.Concat(strDownForce, (bolid as BolidTurbo).DownForce, ";");
            strTurbo = String.Concat(strTurbo, (bolid as BolidTurbo).Turbo, ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add(strNose);
            propertiesCollection.Add(strTurbo);
            propertiesCollection.Add(strRearWing);
            propertiesCollection.Add(strDownForce);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
