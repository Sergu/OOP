using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;
using PluginContracts;

namespace Plugin
{
    public class BolidHybridPlugin : IBolidPlugin
    {
        public string bolidName
        {
            get { return "BolidHybrid"; }
        }
        public Type typeOfBolid
        {
            get { return typeof(BolidHybrid); }
        }
        public HandlerFromFields handler
        {
            get { return new BolidHybridHandler(); }
        }
        public BolidCreator bolidCreator 
        {
            get { return new BolidHybridCreator(); }
        }
        public BolidDeserializerCreator bolidDeserializerCreator
        {
            get { return new BolidHybridDeserializerCreator(); }
        }
        public BolidSerializerCreator bolidSerializerCreator
        {
            get { return new BolidHybridSerializerCreator(); }
        }
        public BolidEditingCreator bolidEditingCreator 
        {
            get { return new BolidHybridEditingCreator(); }
        }

    }
}
