using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal class SalarriedEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transpoetation { get; set; } 
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] 
            { 
                new PayItem("Basic Houres",BasicSalary),
                new PayItem("tansportation", Transpoetation ),
                new PayItem("Housing",Housing),
            
            };
        }
        public override decimal GetSalary() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return BasicSalary + Transpoetation + Housing;
        }
        public  decimal GetSalary(int taxPercentage)
        {
           
            return GetSalary()-(BasicSalary * taxPercentage /100);
        }

        public decimal GetSalary(decimal bouns)
        {

            return GetSalary()+bouns;
        }
    }
}
