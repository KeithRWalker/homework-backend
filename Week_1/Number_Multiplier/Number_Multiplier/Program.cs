using System;
using System.Collections.Generic;

namespace Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool repeatQuestion = true;
            while (repeatQuestion)
            {
                Console.WriteLine("Please enter 3 Numbers separated by a comma");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(',');
                foreach (string entry in splitInput)
                {
                    bool checkNum = Int32.TryParse(entry, out int numValue);
                    if (checkNum == true)
                    {
                        int isNum = Int32.Parse(entry);
                        numbers.Add(isNum);
                    }
                    else
                    {
                        Console.WriteLine("Must Enter a Number");
                    }
                }

                if (numbers.Count == 3)
                {
                    repeatQuestion = false;
                }
                else
                {
                    Console.WriteLine("You must enter exactly 3 numbers");
                }
            }

            Console.WriteLine("Would you like to");
            Console.WriteLine("A. Multiply all of these together");
            Console.WriteLine("B. Square Each of these numbers");
            Console.WriteLine("Enter A, or B to choose");
            string userChoice = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(userChoice) || userChoice != "a" && userChoice != "b")
            {
                Console.WriteLine("Please enter A, or B");
                userChoice = Console.ReadLine();
            }
            if (userChoice == "a")
            {
                Console.WriteLine("You Have Chosen to A. Multiply");
                var result = numbers[0] * numbers[1] * numbers[2];
                Console.WriteLine($"{numbers[0]} x {numbers[1]} x {numbers[2]} = {result}");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("You Have Chosen to B. Square");
                var resultZero = numbers[0] * numbers[0];
                var resultOne = numbers[1] * numbers[1];
                var resultTwo = numbers[2] * numbers[2];
                Console.WriteLine($"{numbers[0]} Squared = {resultZero}");
                Console.WriteLine($"{numbers[1]} Squared = {resultOne}");
                Console.WriteLine($"{numbers[2]} Squared = {resultTwo}");
            }
        }
    }
}
//string input = Console.ReadLine();
//var x = Int32.TryParse(input, out int isNumberBool);
//while (input == "")
//{
//    Console.WriteLine("Empty Input... Please enter 3 Numbers separated by a comma");
//    input = Console.ReadLine();
//}
//if (Int32.TryParse(input, out int isNumber))
//{
//    Console.WriteLine("It's a Number");
//}
//else while (!Int32.TryParse(input, out int isNotNum))
//{
//    Console.WriteLine($"{input} is not a number, Please check your input, and try again!");
//    input = Console.ReadLine();
//}
//// Console.WriteLine(input);