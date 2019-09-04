using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    enum Color
    {
        White,
        Blue,
        Black,
        Red,
        Green,
        Colorless,
    }
    class MagicCard
    {
        public Color ManaColor { get; set; }
        public string Name { get; set; }
        public int ManaCost { get; set; }

        public void Play(int startingMana)
        {
            Console.WriteLine();
            Console.WriteLine($"------- MANA = {startingMana} -------");
            int yourMana = startingMana - ManaCost;
            if (startingMana >= ManaCost)
            {
                Console.WriteLine($"You played the card {Name}");
                Console.WriteLine($"It is a {ManaColor} Card");
                Console.WriteLine($"It costs {ManaCost} Mana");
                Console.WriteLine($"You have {yourMana} left");
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You don't have enough mana to play {Name}");
                Console.WriteLine($"{Name} costs {ManaCost} mana...");
                Console.WriteLine($"you only have {startingMana} mana");
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }

        public void Read()
        {
            Console.WriteLine("----------CARD----------");
            Console.WriteLine($"CARD: {Name} ");
            Console.WriteLine($"COLOR: {ManaColor} ");
            Console.WriteLine($"COST: {ManaCost} ");
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
    }
}
