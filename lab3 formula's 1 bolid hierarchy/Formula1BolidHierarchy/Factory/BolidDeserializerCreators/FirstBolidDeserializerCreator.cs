﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Deserializers;

namespace Formula1BolidHierarchy.Factory.BolidDeserializerCreators
{
    public class FirstBolidDeserializerCreator : BolidDeserializerCreator
    {
        public override BolidDeserializer FactoryMethod()
        {
            return new FirstBolidDeserializer();
        }
    }
}
