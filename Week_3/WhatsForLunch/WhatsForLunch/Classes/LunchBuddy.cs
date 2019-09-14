using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatsForLunch.Classes
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Restaurant Eat()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine($"{FullName} is Eating at {restaurant.Name}");
            return restaurant;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FullName} ate {food} at the office");
        }

        public void Eat(List<Employee> companions)
        {
            StringBuilder friends = new StringBuilder();

            foreach (var companion in companions)
            {
                friends.Append(companion.Name).Append(", ");
            }

            Console.WriteLine($"{FullName} is eating at {Eat().Name} with... {friends}");
            // Console.WriteLine($"{FullName} is eating at {new Restaurant().Name} with... {friends}");
        }

        public void Eat(string food, List<Employee> companions)
        {
            StringBuilder friends = new StringBuilder();

            foreach (var companion in companions)
            {
                friends.Append(companion.Name).Append(", ");
            }

            Console.WriteLine($"{FullName} ordered {food} at {Eat().Name} with... {friends}");
        }

    }
}
