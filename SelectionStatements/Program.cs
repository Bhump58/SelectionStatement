using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Let's play a number guessing game!!");
            Console.WriteLine("");
            Console.Write("Guess a number between 1 and 1000:  ");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }

           
        }
    }
}
