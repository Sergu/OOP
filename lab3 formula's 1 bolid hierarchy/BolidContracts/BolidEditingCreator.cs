﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy
{
    public abstract class BolidEditingCreator
    {
        public abstract Bolids.Bolid FactoryMethod(Bolids.Bolid bolid,List<string> fields);
    }
}
