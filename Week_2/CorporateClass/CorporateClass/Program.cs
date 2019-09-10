using System;
using CorporateClass;
using CorporateClass.Classes;
using CorporateClass.Classes.Employees;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company Name");
            var compName = Console.ReadLine();
            var userComp = new Company(compName);
            userComp.AddOrRemove();
        }
    }
}
