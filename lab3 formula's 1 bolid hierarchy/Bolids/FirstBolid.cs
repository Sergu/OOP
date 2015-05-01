using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy
{
    public class FirstBolid  : IBolid
    {
        public string name { get; set; }
        public string engine {get;set;}
        public string body { get; set; }

        //public FirstBolid(string name,string engine,string body)
        //{
        //    this.name = name;
        //    this.engine = engine;
        //    this.body = body;
        //}
        //public string Serialize()       
        //{
        //    List<string> propertiesCollection = new List<string>();
        //    string str = "{";
        //    string strclass = "class:";
        //    string strname = "name:";
        //    string strengine = "engine:";
        //    string strbody = "body:";
        //    strclass = String.Concat(strclass, "FirstBolid;");
        //    strname = String.Concat(String.Concat(strname, name),";");
        //    strengine = String.Concat(String.Concat(strengine, engine), ";");
        //    strbody = String.Concat(String.Concat(strbody, body), ";");
        //    propertiesCollection.Add(str);
        //    propertiesCollection.Add(strclass);
        //    propertiesCollection.Add(strname);
        //    propertiesCollection.Add(strengine);
        //    propertiesCollection.Add(strbody);
        //    propertiesCollection.Add("}");
        //    str = String.Concat(propertiesCollection);
        //    return str;
        //}
    }
}
