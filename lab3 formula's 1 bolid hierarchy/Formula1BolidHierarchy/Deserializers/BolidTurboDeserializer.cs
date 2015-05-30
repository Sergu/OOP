using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy.Deserializers
{
    public class BolidTurboDeserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            BolidTurbo bolidturbo = new BolidTurbo();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strNose = @"(?<=nose:)([^;]*)";
            string strRearWing = @"(?<=rearwing:)([^;]*)";
            string strDownForce = @"(?<=downforce:)([^;]*)";
            string strTurbo = @"(?<=turbo:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regNose = new Regex(strNose);
            Regex regRearWing = new Regex(strRearWing);
            Regex regDownForce = new Regex(strDownForce);
            Regex regTurbo = new Regex(strTurbo);
            bolidturbo.name = regName.Match(deserializableString).ToString();
            bolidturbo.body = regBody.Match(deserializableString).ToString();
            bolidturbo.engine = regEngine.Match(deserializableString).ToString();
            bolidturbo.nose = regNose.Match(deserializableString).ToString();
            bolidturbo.DownForce = regDownForce.Match(deserializableString).ToString();
            bolidturbo.RearWing = regRearWing.Match(deserializableString).ToString();
            bolidturbo.Turbo = regTurbo.Match(deserializableString).ToString();
            return bolidturbo;
        }
    }
}
