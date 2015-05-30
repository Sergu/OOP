    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy;

namespace PluginContracts
{
    public interface IBolidPlugin
    {
        string bolidName { get; }
        Type typeOfBolid { get; }
        HandlerFromFields handler { get; }
        BolidCreator bolidCreator { get; }
        BolidDeserializerCreator bolidDeserializerCreator { get; }
        BolidSerializerCreator bolidSerializerCreator { get; }
        BolidEditingCreator bolidEditingCreator { get; }
    }
}
