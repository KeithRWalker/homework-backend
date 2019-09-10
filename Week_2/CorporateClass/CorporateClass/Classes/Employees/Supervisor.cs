using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes.Employees
{
    class Supervisor : Employee
    {
        public Supervisor(string name, int age)
        {
            Name = name;
            Age = age;
            Salary = 75000;
        }
    }
}
