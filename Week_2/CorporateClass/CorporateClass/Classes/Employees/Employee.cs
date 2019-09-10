using System;
using System.Collections.Generic;
using System.Text;

using CorporateClass.Classes;

namespace CorporateClass.Classes.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
