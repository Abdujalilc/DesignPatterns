using System;
namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            Employee emp2 = emp1;
            emp2.Name = "Pranaya";
            /*Employee emp3 = emp1;
            emp1.Name = "ChangedPerson";*/
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            /*Console.WriteLine("Emplpyee 3: ");
            Console.WriteLine("Name: " + emp3.Name + ", Department: " + emp3.Department);*/
            Console.Read();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
}