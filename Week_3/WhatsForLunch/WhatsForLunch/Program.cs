using System;
using System.Collections.Generic;
using WhatsForLunch.Classes;

namespace WhatsForLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            var myself = new LunchBuddy("Keith", "Walker");

            var friends = new List<Employee>();
            friends.Add(new Employee("Friend A"));
            friends.Add(new Employee("Friend B"));
            friends.Add(new Employee("Friend C"));

            var byMyself = myself.Eat().Name;
            Console.WriteLine(byMyself);
            //myself.Eat();

            myself.Eat(friends);

            myself.Eat("Pizza", friends);
        }
    }
}
