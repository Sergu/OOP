using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Formula1BolidHierarchy
{
    public static class Deserialization
    {
        public static IBolidSerializer Deserialize(string str)
        {
            string pattern = @"(?<=class:)([^;]*)";
            Regex regClass = new Regex(pattern);
            switch (regClass.Match(str).ToString())
            {
                case "FirstBolid":
                    return new FirstBolidSerializer(FirstBolidDeserialize(str));
                case "Bolid60":
                    return new Bolid60Serializer(Bolid60Deserialize(str));
                case "BolidAtmo":
                    return new BolidAtmoSerializer(BolidAtmoDeserializer(str));
                case "BolidTurbo":
                    return new BolidTurboSerializer(BolidTurboDeserialize(str));
                case "Bolid80":
                    return new Bolid80Serializer(Bolid80Deserialize(str));
                case "NewBolid":
                    return new NewBolidSerializer(NewBolidDeserialize(str));
                default:
                    return null; 
            }
        }
        public static FirstBolid FirstBolidDeserialize(string str)
        {
            FirstBolid firstbolid = new FirstBolid();
            string strName = @"(?<=name:)([^;]*)";
            string strBody = @"(?<=body:)([^;]*)";
            string strEngine = @"(?<=engine:)([^;]*)";
            Regex regName = new Regex(strName);
            Regex regBody = new Regex(strBody);
            Regex regEngine = new Regex(strEngine);
            firstbolid.name = regName.Match(str).ToString();
            firstbolid.body = regBody.Match(str).ToString();
            firstbolid.engine = regEngine.Match(str).ToString();
            return firstbolid;
        }
        public static Bolid60 Bolid60Deserialize(string str)
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
            bolid60.name = regName.Match(str).ToString();
            bolid60.body = regBody.Match(str).ToString();
            bolid60.engine = regEngine.Match(str).ToString();
            bolid60.nose = regNose.Match(str).ToString();
            return bolid60;
        }
        public static BolidAtmo BolidAtmoDeserializer(string str)
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
            bolidatmo.name = regName.Match(str).ToString();
            bolidatmo.body = regBody.Match(str).ToString();
            bolidatmo.engine = regEngine.Match(str).ToString();
            bolidatmo.nose = regNose.Match(str).ToString();
            bolidatmo.DownForce = regDownForce.Match(str).ToString();
            bolidatmo.RearWing = regRearWing.Match(str).ToString();
            return bolidatmo;
        }
        public static BolidTurbo BolidTurboDeserialize(string str)
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
            bolidturbo.name = regName.Match(str).ToString();
            bolidturbo.body = regBody.Match(str).ToString();
            bolidturbo.engine = regEngine.Match(str).ToString();
            bolidturbo.nose = regNose.Match(str).ToString();
            bolidturbo.DownForce = regDownForce.Match(str).ToString();
            bolidturbo.RearWing = regRearWing.Match(str).ToString();
            bolidturbo.Turbo = regRearWing.Match(str).ToString();
            return bolidturbo;
        }
        public static Bolid80 Bolid80Deserialize(string str)
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
            bolid80.name = regName.Match(str).ToString();
            bolid80.body = regBody.Match(str).ToString();
            bolid80.engine = regEngine.Match(str).ToString();
            bolid80.nose = regNose.Match(str).ToString();
            bolid80.DownForce = regDownForce.Match(str).ToString();
            bolid80.RearWing = regRearWing.Match(str).ToString();
            bolid80.FrontWing = regFrontWing.Match(str).ToString();
            return bolid80;
        }
        public static NewBolid NewBolidDeserialize(string str)
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
            newbolid.name = regName.Match(str).ToString();
            newbolid.body = regBody.Match(str).ToString();
            newbolid.engine = regEngine.Match(str).ToString();
            newbolid.nose = regNose.Match(str).ToString();
            newbolid.DownForce = regDownForce.Match(str).ToString();
            newbolid.RearWing = regRearWing.Match(str).ToString();
            newbolid.FrontWing = regFrontWing.Match(str).ToString();
            newbolid.Drs = regDrs.Match(str).ToString();
            newbolid.Kers = regKers.Match(str).ToString();
            newbolid.Turbo = regTurbo.Match(str).ToString();
            return newbolid;
        }
    }
}

//string strName = @"(?<=name:)([^;]*)";
//string strBody = @"?<=body:)([^;]*)";
//string strEngine = @"(?<=engine:)([^;]*)";
//string strNose = @"(?<=nose:)([^;]*)";
//string strFrontWing = @"(?<=frontwing:)([^;]*)";
//string strRearWing = @"(?<=rearwing:)([^;]*)";
//string strTurbo = @"(?<=turbo:)([^;]*)";
//string strDownForce = @"(?<=downforce:)([^;]*)";
//string strDrs = @"(?<=drs:)([^;]*)";
//string strKers = @"(?<=kers:)([^;]*)";


