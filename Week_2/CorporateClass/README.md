# Corporate Class
   * 1. Copy this `Company` class into your `Program.cs` file.

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }
    
        // Create a property for holding a list of current employees
    
        // Create a method that allows external code to add an employee
    
        // Create a method that allows external code to remove an employee
    
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
    
            The constructor will set the value of the public properties
        */
    }

1. Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
2. Consider the concept of [aggregation](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/orientation/09_RELATIONSHIPS.md#aggregation), and modify the `Company` class so that you assign employees to a company.
3. In the `Main` method, create a company, and three employees, and then assign the employees to the company.
4. Update the `Company` class to write the name of each employee to the console. Consider a method named `ListEmployees()`.