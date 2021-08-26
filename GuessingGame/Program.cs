using System;
using System.Collections.Generic;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defines the "list" Guesses.
            List<int> Guesses = new List<int>();
            // stores the return value from the function "createRandomInt()" in the secretNumber variable.
            int secretNumber = createRandomInt();
            // sets the intial value of the variable "numOfGuesses" to be 1.
            int numOfGuesses = 1;
            // Prompts the user to select a difficulty level
            Console.WriteLine("Select Difficulty Level (Easy/Medium/Hard/Cheater)>");
            // stores the user response as the variable "difficultyAnswer"
            string difficultyAnswer = Console.ReadLine().ToLower();
            // Prompts the user to enter a number.
            Console.WriteLine("Guess the secret number between 1 & 100. ");

            // If else statements updates the value of "numOfGuesses" based on the users
            // input stored in the "difficultyAnswer" variable.
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
            else
            {
                //sets the number of guesses to be the largest possible value of integer
                numOfGuesses = int.MaxValue;
            }

            // while loop to facilitate the guessing game. 
            // The loop will run until the number of guesses equals 
            // the value stored in the "numOfGuesses" variable or hits the break
            // when the correct value is entered. 
            while (Guesses.Count < numOfGuesses)
            {
                // prints the the console the text and number of guesses remaining.
                Console.Write($"Remaining guesses({numOfGuesses - (Guesses.Count)})>");
                // stores the users input in the variable "answer"
                string answer = Console.ReadLine();
                // updates the user input stored in the variable answer to be an integer
                // which is then stored in the variable "answerAsNum".
                int answerAsNum = int.Parse(answer);
                // Console.Write(answerAsNum);

                // if the secret number is guessed, prints text and breaks out of while loop.
                if (secretNumber == answerAsNum)
                {
                    Console.WriteLine("You guessed it!!");
                    break;
                }
                else
                {
                    // Console.WriteLine($"{secretNumber}");
                    // Adds the guess to the "Guesses" list (to update the count of guesses)
                    Guesses.Add(answerAsNum);
                    // if the secret number is not guessed correctly prints text too high 
                    // or low and returns to the top of the while loop
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

            // function creates a random number between 1 and 100 
            int createRandomInt()
            {

                Random randomNum = new Random();
                int randomInt = randomNum.Next(1, 100);
                return randomInt;
            };

        }
    }
}

