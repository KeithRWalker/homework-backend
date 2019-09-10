using System;
using System.Collections.Generic;
using System.Text;
using CorporateClass.Classes.Employees;

     namespace CorporateClass.Classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> EmployeeList = new List<Employee>();

        public Company(string name)
        {
            CreatedOn = DateTime.Now;
            Name = name;
        }

        public void AddOrRemove()
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("What would you like to do? (enter 1-3");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Delete Employee");
                var userResp = Convert.ToInt32(Console.ReadLine());
                switch (userResp)
                {
                    case 1:
                        Console.WriteLine("You have selected Add Employee!");
                        AddEmployee();
                        menu = false;
                        break;
                    case 2:
                        Console.WriteLine("You have selected Delete an employee!");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter 1-2");
                        break;
                }
            }
        }

        // Create a method that allows external code to add an employee
        public void AddEmployee()
        {
            Console.WriteLine("Enter Employee's First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Employee's Last Name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter Employee's Age");
            var age = Convert.ToInt32(Console.ReadLine());
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("New Employee Position...");
                Console.WriteLine("1. Boss");
                Console.WriteLine("2. Supervisor");
                Console.WriteLine("3. Manager");
                Console.WriteLine("4. Clerk");
                var empPos = Convert.ToInt32(Console.ReadLine());
                var fullName = $"{firstName} {lastName}";
                Employee empToAdd;

                switch (empPos)
                {
                    case 1:
                        empToAdd = new Boss(fullName, age);
                        EmployeeList.Add(empToAdd);
                        Console.WriteLine($"{empToAdd.Name} the {empToAdd.GetType().Name} was added to {Name} Employee list");
                        menu = false;
                        break;
                    case 2:
                        empToAdd = new Supervisor(fullName, age);
                        EmployeeList.Add(empToAdd);
                        Console.WriteLine($"{empToAdd.Name} the {empToAdd.GetType().Name} was added to {Name} Employee list");
                        menu = false;
                        break;
                    case 3:
                        empToAdd = new Manager(fullName, age);
                        EmployeeList.Add(empToAdd);
                        Console.WriteLine($"{empToAdd.Name} the {empToAdd.GetType().Name} was added to {Name} Employee list");
                        menu = false;
                        break;
                    case 4:
                        empToAdd = new Clerk(fullName, age);
                        EmployeeList.Add(empToAdd);
                        Console.WriteLine($"{empToAdd.Name} the {empToAdd.GetType().Name} was added to {Name} Employee list");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter 1-3");
                        break;
                }
            }
        }

        // Create a method that allows external code to remove an employee
        public void deleteEmp()
        {

        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
    
            The constructor will set the value of the public properties
        */
    }
}
