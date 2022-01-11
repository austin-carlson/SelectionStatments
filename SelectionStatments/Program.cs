using System;

namespace SelectionStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("I'm thinking of a number between 1 and 1000. Can you guess it? Type your guess below (NO LETTERS!!!) good luck :)");

            var userInput = int.Parse(Console.ReadLine());

            while (userInput != favNumber)
            {
                if (userInput > favNumber)
                {
                    Console.WriteLine("OOOOP Litttle too high!");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("OOpsie little too low there!");
                    userInput = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("You got 'er! Congrats!");
        }
    }
}
