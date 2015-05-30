using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy.Deserializers
{
    public class BolidAtmoDeserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            BolidAtmo bolidatmo = new BolidAtmo();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strNose = @"(?<=nose:)([^;]*)";
            string strRearWing = @"(?<=rearwing:)([^;]*)";
            string strDownForce = @"(?<=downforce:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regNose = new Regex(strNose);
            Regex regRearWing = new Regex(strRearWing);
            Regex regDownForce = new Regex(strDownForce);
            bolidatmo.name = regName.Match(deserializableString).ToString();
            bolidatmo.body = regBody.Match(deserializableString).ToString();
            bolidatmo.engine = regEngine.Match(deserializableString).ToString();
            bolidatmo.nose = regNose.Match(deserializableString).ToString();
            bolidatmo.DownForce = regDownForce.Match(deserializableString).ToString();
            bolidatmo.RearWing = regRearWing.Match(deserializableString).ToString();
            return bolidatmo;
        }
    }
}
