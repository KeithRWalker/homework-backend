using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    enum TypeOfPet
    {
        Arachnid,
        Dog,
        Cat,
        Lizard,
        Snake,
    }

    class Pets
    {
        public TypeOfPet Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private bool _isFriendly;

        public Pets(string name, int age, TypeOfPet typeOfPet)
        {
            Name = name;
            Age = age;
            Type = typeOfPet;
            switch (typeOfPet)
            {
                case TypeOfPet.Dog:
                    _isFriendly = true;
                    break;
                case TypeOfPet.Cat:
                    _isFriendly = true;
                    break;
                default:
                    _isFriendly = false;
                    break;
            }
        }
        public void Pet()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"> You pet {Name}...");
            Console.WriteLine();
            switch (_isFriendly)
            {
                case true:
                    Console.WriteLine($"> {Name} appreciates your pets");
                    break;
                case false:
                    Console.WriteLine($"> {Name} is a mean {Type} you fool, You just got bit!");
                    break;
            }
            Console.WriteLine("------------------------");
        }

        public void Observe()
        {
            string isFriendly = "error";
            switch (_isFriendly)
            {
                case true:
                    isFriendly = $"{Name} looks pretty nice, Maybe you should pet it!";
                    Console.WriteLine();
                    break;
                case false:
                    isFriendly = $"{Name} looks pretty gnarly, You should stay away from it!";
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine($"You see an animal, and it looks like it is a {Type}");
            Console.WriteLine($"You See a nearby name tag on the {Type}, It's name is {Name}");
            Console.WriteLine($"The name tag also says {Name} is {Age} years old");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{isFriendly}");
            Console.WriteLine();
        }
    }
}
