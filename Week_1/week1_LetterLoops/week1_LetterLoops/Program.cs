using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace week1_LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Select Which Program to Run");
            //Console.WriteLine("1. LetterLoops");
            //string progSel = Console.ReadLine();
            //while (string.IsNullOrEmpty(progSel))
            //{
            //    Console.WriteLine("Your entry was blank... Please Enter a #");
            //    progSel = Console.ReadLine();
            //}
            Console.WriteLine("Enter a word");
            string userString = Console.ReadLine();
            while (string.IsNullOrEmpty(userString))
            {
                Console.WriteLine("Your entry was blank... Please Enter a Word!");
                userString = Console.ReadLine();
            }

            Console.WriteLine($"You Have Entered the Word {userString}, it is {userString.Length} characters long");
            for (var i = 0; i < userString.Length; i++)
            {
                var multiplier = i + 1;
                var currentChar = userString[i];
                var charCombo = new StringBuilder();
                for (var x = 0; x < multiplier; x++)
                {
                    charCombo.Append(currentChar);
                }

                Console.WriteLine(charCombo);
            }
        }
    }
}
