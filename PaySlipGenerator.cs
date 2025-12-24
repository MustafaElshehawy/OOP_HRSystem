using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal class PaySlipGenerator
    {
        public void Generate(Employee employee)
        { 
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName}");
            message.AppendLine("please find below your payslip details:");
            foreach (var payItem in payItems)
            {
                message.AppendLine($"{payItem.Name}\t\t{payItem.Value}");
            }
        }
    }
}
