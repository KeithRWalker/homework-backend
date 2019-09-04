using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Title
    {
        public string TitleName;

        public Title(string title)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("______________________");
            Console.WriteLine();
            Console.WriteLine($"-------- {title} -------");
            Console.WriteLine("______________________");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
