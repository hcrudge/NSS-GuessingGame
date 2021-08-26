using System;
using System.Collections.Generic;
using System.Linq;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.Write("Guess the secret number: ");
            string answer = Console.ReadLine().ToLower();
            // Console.Write(answer);
            if(secretNumber == int.Parse(answer))
            {
                Console.WriteLine("You guessed it!!");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again.");
            }
        }
    }
}
