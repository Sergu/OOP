using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Formula1BolidHierarchy.Bolids;

namespace Formula1BolidHierarchy.Deserializers
{
    public class FirstBolidDeserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            FirstBolid firstbolid = new FirstBolid();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            firstbolid.name = regName.Match(deserializableString).ToString();
            firstbolid.body = regBody.Match(deserializableString).ToString();
            firstbolid.engine = regEngine.Match(deserializableString).ToString();
            return firstbolid;
        }
    }
}
