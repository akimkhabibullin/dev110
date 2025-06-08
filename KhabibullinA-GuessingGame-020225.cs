using System;

class GuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int min = 1, max = 11; // Max is exclusive in Random.Next
        bool playAgain = true;

        while (playAgain)
        {
            int randomNumber = random.Next(min, max);
            int guess = 0, attempts = 0;
            Console.WriteLine("I have chosen a number between 1 and 10. Try to guess it!");

            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    attempts++;
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.Write("Do you want to play again? (y/n): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "y");
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
