﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1BolidHierarchy.Serializers;

namespace Formula1BolidHierarchy.Factory.BolidSerializerCreators
{
    public class FirstBolidSerializerCreator : BolidSerializerCreator
    {
        public override BolidSerializer FactoryMethod()
        {
            return new FirstBolidSerializer();
        }
    }
}
