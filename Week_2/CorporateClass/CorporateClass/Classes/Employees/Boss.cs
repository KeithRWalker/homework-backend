using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes.Employees
{
    class Boss : Employee
    {
        public bool IsAdmin => true;
        public Boss(string name, int age)
        {
            Name = name;
            Age = age;
            Salary = 1000000;
        }
    }
}
