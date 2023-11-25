using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp25_11
{
    public class Client
    {
        private AbstractPrototype _prot;
        private List<AbstractPrototype> _prototypes = new List<AbstractPrototype>();

        public Client(AbstractPrototype prototype)
        {
            _prot = prototype;
        }

        public void Operation(int id)
        {
            AbstractPrototype copy = _prot.Clone();
            copy.ChangeId(id);
            _prototypes.Add(copy);
        }
        
        public string GetObjects() => String.Join(" ", _prototypes.Select(prot => prot.GetInfo()).ToArray());
            
    }
}