using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes.Employees
{
    class Manager : Employee
    {
        public Manager(string name, int age)
        {
            Name = name;
            Age = age;
            Salary = 50000;
        }
    }
}
