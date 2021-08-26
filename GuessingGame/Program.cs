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
            int secretNumber = createRandomInt();
            while (Guesses.Count < 4)
            {
                Console.WriteLine("Guess the secret number. ");
                Console.Write($"Remaining guesses({4 - (Guesses.Count)})>");
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
                    // Console.WriteLine($"{secretNumber}");
                    Guesses.Add(numAnswer);
                    if (secretNumber > numAnswer)
                    {
                        Console.WriteLine("Incorrect! Your guess is too low.");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Your guess is too high.");
                    }

                }
            };
            int createRandomInt()
            {

                Random randomNum = new Random();
                int randomInt = randomNum.Next(1, 100);
                return randomInt;
            }
        }
    }
}
