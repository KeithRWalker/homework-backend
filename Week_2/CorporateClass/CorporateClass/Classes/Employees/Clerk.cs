using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes.Employees
{
    class Clerk : Employee
    {
        public Clerk(string name, int age)
        {
            Name = name;
            Age = age;
            Salary = 25000;
        }
    }
}
