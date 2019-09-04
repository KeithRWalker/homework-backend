using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Bands
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public bool SeenLive { get; set; }

        private bool _isPlaying;

        public Bands(string name, string genre, bool seenLive)
        {
            Name = name;
            Genre = genre;
            SeenLive = seenLive;
        }

        public void Play()
        {
            Console.WriteLine("--------- PLAY ---------");
            switch (_isPlaying)
            {
                case true:
                    Console.WriteLine($"{Name} is already playing");
                    break;
                case false:
                    _isPlaying = true;
                    Console.WriteLine($"{Name} is now playing");
                    break;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }

        public void StopPlaying()
        {
            Console.WriteLine("--------- STOP ---------");
            switch (_isPlaying)
            {
                case true:
                    _isPlaying = false;
                    Console.WriteLine($"{Name} Stopped Playing");
                    break;
                case false:
                    Console.WriteLine($"{Name} Isn't currently playing so you can't stop it");
                    break;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }

        public void CheckIfSeenLive()
        {
            Console.WriteLine("--------- LIVE ---------");
            switch (SeenLive)
            {
                case true:
                    Console.WriteLine($"You have seen {Name} Live");
                    break;
                case false:
                    Console.WriteLine($"You have not seen {Name} live");
                    break;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
    }
}
