using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;
using System.Text.RegularExpressions;

namespace Plugin
{
    public class BolidHybridDeserializer : BolidDeserializer
    {
        public override Formula1BolidHierarchy.Bolids.Bolid Deserialize(string deserializableString)
        {
            BolidHybrid bolid = new BolidHybrid();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strWheels = @"(?<=wheels:)([^;]*)";
            string strTurbo = @"(?<=turbo:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regWheels = new Regex(strWheels);
            Regex regTurbo = new Regex(strTurbo);
            bolid.name = regName.Match(deserializableString).ToString();
            bolid.body = regBody.Match(deserializableString).ToString();
            bolid.engine = regEngine.Match(deserializableString).ToString();
            bolid.Wheels = regWheels.Match(deserializableString).ToString();
            bolid.Turbo = regTurbo.Match(deserializableString).ToString();
            return bolid;
        }
    }
}
