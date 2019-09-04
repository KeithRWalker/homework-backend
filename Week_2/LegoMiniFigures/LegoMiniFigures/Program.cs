using System;
using LegoMiniFigures.Classes;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To World of Legocraft!");

            Console.WriteLine("Please Enter a name for your Lego Hero");
            var figName = Console.ReadLine();
            var userFig = new Figure(figName);

            Console.WriteLine("Please Select a Class");
            Console.WriteLine("1. Warrior // INT:1 VIT:7 STR:7 SPD:5");
            Console.WriteLine("2. Wizard // INT:9 VIT:4 STR:2 SPD:5");
            Console.WriteLine("3. Rogue // INT:2 VIT:3 STR:6 SPD:9");
            Console.WriteLine("4. Paladin // INT:5 VIT:6 STR:6 SPD:3");
            var figSelect = Convert.ToInt32(Console.ReadLine());
            switch (figSelect)
            {
                case 1:
                    userFig.SetClass(FClass.Warrior);
                    break;
                case 2:
                    userFig.SetClass(FClass.Wizard);
                    break;
                case 3:
                    userFig.SetClass(FClass.Rogue);
                    break;
                case 4:
                    userFig.SetClass(FClass.Paladin);
                    break;
                default:
                    Console.WriteLine("Please enter 1-4");
                    break;
            }
            userFig.GetInfo();

            var troll = new Figure("A Troll");
            troll.SetClass(FClass.Troll);
            var goblin = new Figure("A Goblin");
            goblin.SetClass(FClass.Goblin);
            var orc = new Figure("An Orc");
            orc.SetClass(FClass.Orc);
            var demon = new Figure("A Demon");
            demon.SetClass(FClass.Demon);


            while (userFig.IsAlive)
            {
                if (userFig.IsAlive)
                {
                    userFig.StartFight(troll);
                    userFig.EndFight();
                }
                else break;

                if (userFig.IsAlive)
                {
                    userFig.StartFight(goblin);
                    userFig.EndFight();
                }
                else break;

                if (userFig.IsAlive)
                {
                    userFig.StartFight(orc);
                    userFig.EndFight();
                }
                else break;

                if (userFig.IsAlive)
                {
                    userFig.StartFight(demon);
                    userFig.EndFight();
                }
                else break;
            }

        }
    }
}
