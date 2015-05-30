using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy.Deserializers
{
    public class NewBolidDeserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            NewBolid newbolid = new NewBolid();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strNose = @"(?<=nose:)([^;]*)";
            string strRearWing = @"(?<=rearwing:)([^;]*)";
            string strDownForce = @"(?<=downforce:)([^;]*)";
            string strFrontWing = @"(?<=frontwing:)([^;]*)";
            string strDrs = @"(?<=drs:)([^;]*)";
            string strKers = @"(?<=kers:)([^;]*)";
            string strTurbo = @"(?<=turbo:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regNose = new Regex(strNose);
            Regex regRearWing = new Regex(strRearWing);
            Regex regDownForce = new Regex(strDownForce);
            Regex regFrontWing = new Regex(strFrontWing);
            Regex regDrs = new Regex(strDrs);
            Regex regKers = new Regex(strKers);
            Regex regTurbo = new Regex(strTurbo);
            newbolid.name = regName.Match(deserializableString).ToString();
            newbolid.body = regBody.Match(deserializableString).ToString();
            newbolid.engine = regEngine.Match(deserializableString).ToString();
            newbolid.nose = regNose.Match(deserializableString).ToString();
            newbolid.DownForce = regDownForce.Match(deserializableString).ToString();
            newbolid.RearWing = regRearWing.Match(deserializableString).ToString();
            newbolid.FrontWing = regFrontWing.Match(deserializableString).ToString();
            newbolid.Drs = regDrs.Match(deserializableString).ToString();
            newbolid.Kers = regKers.Match(deserializableString).ToString();
            newbolid.Turbo = regTurbo.Match(deserializableString).ToString();
            return newbolid;
        }
    }
}
