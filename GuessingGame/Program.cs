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
            int numOfGuesses = 1;
            Console.WriteLine("Select Difficulty Level (Easy/Medium/Hard)>");
            string difficultyAnswer = Console.ReadLine().ToLower();
            Console.WriteLine("Guess the secret number between 1 & 100. ");

            while (Guesses.Count < numOfGuesses)
            {
                if (difficultyAnswer == "easy")
                {
                    numOfGuesses = 8;
                }
                else if (difficultyAnswer == "medium")
                {
                    numOfGuesses = 6;
                }
                else if (difficultyAnswer == "hard")
                {
                    numOfGuesses = 4;
                }
                Console.Write($"Remaining guesses({numOfGuesses - (Guesses.Count)})>");
                string answer = Console.ReadLine().ToLower();
                int answerAsNum = int.Parse(answer);
                // Console.Write(answerAsNum);




                if (secretNumber == answerAsNum)
                {
                    Console.WriteLine("You guessed it!!");
                    break;
                }
                else
                {
                    // Console.WriteLine($"{secretNumber}");
                    Guesses.Add(answerAsNum);
                    if (secretNumber > answerAsNum)
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
            };



        }
    }
}

