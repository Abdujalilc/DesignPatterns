using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingElse();
            WriteSomethingAgain();
            Console.ReadLine();
        }

        private static void WriteSomething()
        {
            var person = new Person("Milos Protic", 30);
            WriteMessage(person);
        }

        private static void WriteSomethingElse()
        {
            var person = new Person("John Doe", 29);
            WriteMessage(person);
        }


        private static void WriteSomethingAgain()
        {
            var person = new Person("Jack Fishing", 49);
            WriteMessage(person);
        }

        private static void WriteMessage(Person person)
        {
            Console.WriteLine($"{person.Name} lives in {person.City}, " +
              $"{person.State} and he is {person.Age} years old!");
        }
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string State => Constants.STATE;
        public string City => Constants.CITY;
        public int Age { get; set; }
        public string Name { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine($"{Name} lives in {City}, " +
              $"{State} and he is {Age} years old!");
        }        
    }
    public static class Constants
    {
        public const string CITY = "Novi Sad";
        public const string STATE = "Serbia";
    }

}
