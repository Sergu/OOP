using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1BolidHierarchy
{
    public interface Creator
    {
        IBolidSerializer FactoryMethod(IBolid obj);
    }

    public class FirstBolidCreator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            FirstBolid bolid = obj as FirstBolid;
            return new FirstBolidSerializer(bolid);
        }
    }
    public class Bolid60Creator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            Bolid60 bolid = obj as Bolid60;
            return new Bolid60Serializer(bolid);
        }
    }
    public class BolidAtmoCreator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            BolidAtmo bolid = obj as BolidAtmo;
            return new BolidAtmoSerializer(bolid);
        }
    }
    public class BolidTurboCreator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            BolidTurbo bolid = obj as BolidTurbo;
            return new BolidTurboSerializer(bolid);
        }
    }
    public class Bolid80Creator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            Bolid80 bolid = obj as Bolid80;
            return new Bolid80Serializer(bolid);
        }
    }
    public class NewBolidCreator : Creator
    {
        public IBolidSerializer FactoryMethod(IBolid obj)
        {
            NewBolid bolid = obj as NewBolid;
            return new NewBolidSerializer(bolid);
        }
    }
}
