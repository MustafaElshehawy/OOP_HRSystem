using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal class HourlyEmployee :Employee
    {
        public decimal HourRate { get; set; }
        public decimal TotalWorkingHours { get; set; }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return HourRate * TotalWorkingHours ;
        }
    }
}
