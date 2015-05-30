using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy.Deserializers
{
    public class Bolid80Deserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            Bolid80 bolid80 = new Bolid80();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strNose = @"(?<=nose:)([^;]*)";
            string strRearWing = @"(?<=rearwing:)([^;]*)";
            string strDownForce = @"(?<=downforce:)([^;]*)";
            string strFrontWing = @"(?<=frontwing:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regNose = new Regex(strNose);
            Regex regRearWing = new Regex(strRearWing);
            Regex regDownForce = new Regex(strDownForce);
            Regex regFrontWing = new Regex(strFrontWing);
            bolid80.name = regName.Match(deserializableString).ToString();
            bolid80.body = regBody.Match(deserializableString).ToString();
            bolid80.engine = regEngine.Match(deserializableString).ToString();
            bolid80.nose = regNose.Match(deserializableString).ToString();
            bolid80.DownForce = regDownForce.Match(deserializableString).ToString();
            bolid80.RearWing = regRearWing.Match(deserializableString).ToString();
            bolid80.FrontWing = regFrontWing.Match(deserializableString).ToString();
            return bolid80;
        }
    }
}
