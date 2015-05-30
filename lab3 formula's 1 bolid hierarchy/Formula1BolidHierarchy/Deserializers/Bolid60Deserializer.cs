using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Bolids;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy.Deserializers
{
    public class Bolid60Deserializer : BolidDeserializer
    {
        public override Bolid Deserialize(string deserializableString)
        {
            Bolid60 bolid60 = new Bolid60();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            string strNose = @"(?<=nose:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            Regex regNose = new Regex(strNose);
            bolid60.name = regName.Match(deserializableString).ToString();
            bolid60.body = regBody.Match(deserializableString).ToString();
            bolid60.engine = regEngine.Match(deserializableString).ToString();
            bolid60.nose = regNose.Match(deserializableString).ToString();
            return bolid60;
        }
    }
}
