using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal abstract class Employee:Person
    {
        public string Email { get; internal set; }

        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
        
    }
}
