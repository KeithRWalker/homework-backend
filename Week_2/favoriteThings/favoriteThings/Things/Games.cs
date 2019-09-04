using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    enum Rating
    {
        E,
        T,
        M,
    }
    class Games
    {
        public Rating GameRating { get; set; }
        public string Name { get; set; }
        public string GameConsole { get; set; }
        public string Genre { get; set; }

        private int _ageRestrict;

        public void Play(int age)
        {
            switch (GameRating)
            {
                case Rating.M:
                    _ageRestrict = 16;
                    break;
                case Rating.T:
                    _ageRestrict = 13;
                    break;
                case Rating.E:
                    _ageRestrict = 0;
                    break;
                default:
                    _ageRestrict = 0;
                    break;
            }

            var reqAge = _ageRestrict;

            if (age < _ageRestrict)
            {
                Console.WriteLine($"You are {age} years old, {Name} is rated {GameRating}.");
                Console.WriteLine($"You need to be at least {reqAge} to play {Name} you little scrub. Go play Minecraft");
                Console.WriteLine();
            }
            else if (age >= _ageRestrict)
            {
                Console.WriteLine($"You are {age} years old which is old enough to play {Name}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This game doesn't have a rating, and you shouldn't see this");
                Console.WriteLine();
            }
        }

        public void Check()
        {
            switch (GameRating)
            {
                case Rating.M:
                    _ageRestrict = 16;
                    break;
                case Rating.T:
                    _ageRestrict = 13;
                    break;
                case Rating.E:
                    _ageRestrict = 1;
                    break;
                default:
                    _ageRestrict = 0;
                    break;
            }

            Console.WriteLine("----------GAME----------");
            Console.WriteLine($"TITLE: {Name}");
            Console.WriteLine($"SYSTEMS: {GameConsole}");
            Console.WriteLine($"RATING: {GameRating}");
            Console.WriteLine($"GENRE: {Genre}");
            Console.WriteLine("------------------------");
        }
    }
}
