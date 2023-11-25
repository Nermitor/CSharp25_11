using System;

namespace CSharp25_11
{
    public abstract class AbstractPrototype
    {
        public abstract AbstractPrototype Clone();

        public abstract string GetInfo();
        public abstract void ChangeId(int newId);
    }

    public class ConcretePrototype1: AbstractPrototype
    {
        private string _data;
        private int _id;

        public ConcretePrototype1(string data, int id)
        {
            _data = data;
            _id = id;
        }

        public override AbstractPrototype Clone() => new ConcretePrototype1(_data, _id);
        public override string GetInfo() => $"CP1={_data}={_id}";
        public override void ChangeId(int newId) => _id = newId;
    }
    
    public class ConcretePrototype2: AbstractPrototype
    {
        private string _data;
        private int _id;

        public ConcretePrototype2(string data, int id)
        {
            _data = data;
            _id = id;
        }
        public override AbstractPrototype Clone() => new ConcretePrototype2(_data, _id);
        public override string GetInfo() => $"CP2={_data}={_id}";
        public override void ChangeId(int newId) => _id = newId;
    }
}