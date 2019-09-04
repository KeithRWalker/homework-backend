using System;

using FavoriteThings.Things;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // // // // // PETS \\ \\ \\ \\ \\
            new Title("PETS");

            var odin = new Pets("Odin", 12, TypeOfPet.Dog);
            var noodle = new Pets("Noodle", 1, TypeOfPet.Snake);

            odin.Observe();
            odin.Pet();

            noodle.Observe();
            noodle.Pet();

            // // // // //-------\\ \\ \\ \\ \\

            Console.WriteLine();

            // // // // //-GAMES-\\ \\ \\ \\ \\
            new Title("Games");

            var cod = new Games
            {
                Name = "Call Of Duty",
                GameConsole = "Xbox/PS4/PC",
                Genre = "Shooter",
                GameRating = Rating.M,
            };

            var minecraft = new Games
            {
                Name = "Minecraft",
                GameConsole = "Everything",
                Genre = "Build stuff",
                GameRating = Rating.E,
            };

            cod.Check();
            cod.Play(8);
            minecraft.Check();
            minecraft.Play(8);
            // // // // //-------\\ \\ \\ \\ \\

            Console.WriteLine();

            // // // // // MAGIC CARDS \\ \\ \\ \\ \\
            new Title("CARDS");

            var kefnet = new MagicCard()
            {
                Name = "God-Eternal Kefnet",
                ManaCost = 4,
                ManaColor = Color.Blue
            };

            var blackLotus = new MagicCard()
            {
                Name = "Black Lotus",
                ManaCost = 0,
                ManaColor = Color.Colorless,
            };

            kefnet.Read();
            kefnet.Play(5);
            kefnet.Play(3);
            blackLotus.Read();
            blackLotus.Play(1);
            // // // // //---------------\\ \\ \\ \\ \\

            Console.WriteLine();

            // // // // //-BANDS-\\ \\ \\ \\ \\
            new Title("BANDS");

            var tool = new Bands("TOOL", "Sorta Metal", true);
            
            var wardruna = new Bands("Wardruna", "Viking", false);

            tool.CheckIfSeenLive();
            tool.Play();
            tool.StopPlaying();

            wardruna.CheckIfSeenLive();
            wardruna.Play();
            wardruna.StopPlaying();
            // // // // //--------\\ \\ \\ \\ \\
        }
    }
}
