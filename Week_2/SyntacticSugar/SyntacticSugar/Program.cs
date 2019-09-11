using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBugsPreds = new List<string>() {"Pred A", "Pred B", "Pred C"};
            var myBugsPrey = new List<string>() {"Prey A", "Prey B", "Prey C"};
            var myBug = new Bug("My Bug", "It's Species", myBugsPreds, myBugsPrey);

            var preyList = myBug.PreyList();
            var predList = myBug.PredatorList();
            Console.WriteLine(preyList);
            Console.WriteLine(predList);

            var prey = "Prey B";
            Console.WriteLine(myBug.Eat(prey));
        }
    }
}
