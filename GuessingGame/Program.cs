using System;
using System.Collections.Generic;
using System.Linq;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Guesses = new List<int>();
            while (Guesses.Count < 4)
            {
                int secretNumber = 42;
                Console.WriteLine("Guess the secret number. ");
                Console.Write($"Your guess({Guesses.Count + 1})>");
                string answer = Console.ReadLine().ToLower();
                int numAnswer = int.Parse(answer);
                // Console.Write(numAnswer);
                if (secretNumber == numAnswer)
                {
                    Console.WriteLine("You guessed it!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again.");
                    Guesses.Add(numAnswer);

                }
            };
        }
    }
}
