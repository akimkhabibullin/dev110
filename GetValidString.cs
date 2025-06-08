/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Get Valid String
*    
*    Description: 
*    this 
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         02/23/2025         Initial Release 
*    1
* 
*/
using System;

class GetValidString
{
    static string GetValidStrings(string prompt, int minLength)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (input.Length < minLength)
            {
                Console.WriteLine($"Invalid value. {prompt.TrimEnd(':')} must be at least {minLength} character{(minLength == 1 ? "" : "s")} long.");
            }
        } while (input.Length < minLength);
        return input;
    }

    static string GetValidStrings(string prompt, int minLength, int maxLength)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (input.Length < minLength || input.Length > maxLength)
            {
                Console.WriteLine($"Invalid value. {prompt.TrimEnd(':')} must be between {minLength} and {maxLength} characters long.");
            }
        } while (input.Length < minLength || input.Length > maxLength);
        return input;
    }

    static void Main()
    {
        // Get inputs with appropriate prompts and constraints
        string name = GetValidStrings("Please enter name: ", 1);
        string description = GetValidStrings("Please enter description: ", 0, 20);
        string productId = GetValidStrings("Please enter Product Id: ", 4, 5);
        string state = GetValidStrings("Please enter state abbreviation: ", 2, 2);

        // Output results
        Console.WriteLine($"\nName: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"State: {state}");
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}