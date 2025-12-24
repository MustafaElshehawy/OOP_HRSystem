using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal class PayItem
    {
        //An Immutable Object is an object whose state (its data)
        //cannot be modified after it is created. If you want to change the values,
        //you must create a new instance (a new copy) with the updated data.

        public String Name { get;  }
        public Decimal Value {  get; }

        public PayItem(string name,decimal value)
        {
            Name = name;
            Value = value;
        }

    }
}
