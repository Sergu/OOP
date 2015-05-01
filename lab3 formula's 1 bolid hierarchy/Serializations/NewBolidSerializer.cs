using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy
{
    public class NewBolidSerializer : IBolidSerializer
    {
        public IBolid bolid { get; set; }
        public NewBolidSerializer(NewBolid obj)
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
            string strKers = "kers:";
            string strDrs = "drs:";
            string strTurbo = "turbo:";
            string strFrontWing = "frontwing:";
            strclass = String.Concat(strclass, "NewBolid;");
            strname = String.Concat(String.Concat(strname, bolid.name), ";");
            strengine = String.Concat(String.Concat(strengine, bolid.engine), ";");
            strbody = String.Concat(String.Concat(strbody, bolid.body), ";");
            strNose = string.Concat(strNose, (bolid as NewBolid).nose, ";");
            strRearWing = String.Concat(strRearWing, (bolid as NewBolid).RearWing, ";");
            strDownForce = String.Concat(strDownForce, (bolid as NewBolid).DownForce, ";");
            strKers = String.Concat(strKers, (bolid as NewBolid).Kers, ";");
            strDrs = String.Concat(strDrs, (bolid as NewBolid).Drs, ";");
            strTurbo = String.Concat(strTurbo, (bolid as NewBolid).Turbo, ";");
            strFrontWing = String.Concat(strFrontWing, (bolid as NewBolid).FrontWing, ";");
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
