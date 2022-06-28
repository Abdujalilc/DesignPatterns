using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee test=employeeBusinessLogic.GetEmployeeDetails(10);

            Console.WriteLine(JsonSerializer.Serialize(test));
            Console.ReadLine();
        } 
    }
}
