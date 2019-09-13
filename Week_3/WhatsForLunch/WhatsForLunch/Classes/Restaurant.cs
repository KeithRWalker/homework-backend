using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsForLunch.Classes
{
    class Restaurant
    {
        public string Name { get; }

        private List<string> _nameList => new List<string> { "Burger King", "Taco Bell", "McDonald's", "Chik'Fil'A", "Panda Express", "Little Ceasar's", "Cook Out", "The Bar" };

        public Restaurant()
        {
            var index = new Random().Next(_nameList.Count);
            Name = _nameList[index];
        }
    }
}
