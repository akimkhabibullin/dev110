using System;

class NumberValidation
{
    static void Main()
    {
        double number;
        int attempts = 0;
        bool isValid = false;

        Console.WriteLine("Please enter a number:");

        while (!isValid)
        {
            string input = Console.ReadLine();
            attempts++;

            if (double.TryParse(input, out number))
            {
                isValid = true;
                Console.WriteLine($"Congratulations! You entered {number}. It took you {attempts} attempts.");
            }
            else
            {
                Console.WriteLine("That's not a valid number! Try again.");
            }
        }
    }
}

