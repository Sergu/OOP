using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Serializations
{
    public class BolidAtmoSerializer :IBolidSerializer
    {
        public Bolid bolid { get; set; }
        public BolidAtmoSerializer(BolidAtmo obj)
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
            strclass = String.Concat(strclass, "BolidAtmo;");
            strname = String.Concat(String.Concat(strname, bolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, bolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, bolid.body), ";");
            strNose = string.Concat(strNose, (bolid as BolidAtmo).nose, ";");
            strRearWing = String.Concat(strRearWing, (bolid as BolidAtmo).RearWing, ";");
            strDownForce = String.Concat(strDownForce, (bolid as BolidAtmo).DownForce, ";");
            propertiesCollection.Add(str);
            propertiesCollection.Add(strclass);
            propertiesCollection.Add(strname);
            propertiesCollection.Add(strengine);
            propertiesCollection.Add(strbody);
            propertiesCollection.Add(strNose);
            propertiesCollection.Add(strRearWing);
            propertiesCollection.Add(strDownForce);
            propertiesCollection.Add("}");
            str = String.Concat(propertiesCollection);
            return str;
        }
    }
}
