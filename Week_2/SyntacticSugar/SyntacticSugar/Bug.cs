using System;
using System.Collections.Generic;
using System.Text;

namespace SyntacticSugar
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "Default Name";
        public string Species { get; } = "Default Species";
        public ICollection<string> Predators { get; } = new List<string>();
        public ICollection<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
/*        public string FormalName
        {
            get
            {
                return $"{this.Name} the {this.Species}";
            }
        }*/

        public string FormalName => $"{this.Name} the {this.Species}";

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
        }

        // Convert this method to an expression member
        /*        public string PreyList()
                {
                    var commaDelimitedPrey = string.Join(",", this.Prey);
                    return commaDelimitedPrey;
                }*/

            
        public string PreyList() => string.Join(",", Prey);

        // Convert this method to an expression member
/*        public string PredatorList()
        {
            var commaDelimitedPredators = string.Join(",", this.Predators);
            return commaDelimitedPredators;
        }*/

        public string PredatorList() => string.Join(",", Predators);

        // Convert this to expression method (hint: use a C# ternary)
/*        public string Eat(string food)
        {
            if (this.Prey.Contains(food))
            {
                return $"{this.Name} ate the {food}.";
            }
            else
            {
                return $"{this.Name} is still hungry.";
            }
        }*/

        public string Eat(string food) => Prey.Contains(food) ? $"{Name} Ate the Food" : $"{Name} Is still Hungry";
    }
}
