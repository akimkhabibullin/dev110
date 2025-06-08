/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Graded Exercise Hello Again
*    
*    Description: 
*    This program will ask the user for theri name and will then tell you how many letter that name has and also will use a possible tax precentage to tell you the price for a 10.00$ thing
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         01/12/2025         Initial Release 
*    1
* 
*/

using System;

class ConsoleApp3
{
    static void Main(String[] agrs)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        int nameLength = name.Length;

        Console.WriteLine($"Hello, {name}! Did you realize that your name contains {nameLength} characters?\n");

        Console.Write("Enter a possible sales tax rate percentage: ");
        double taxRate = double.Parse(Console.ReadLine());

        decimal price = 10.00m;
        decimal tax = price * (decimal)(taxRate / 100);
        Console.WriteLine($"At that rate, tax on {price:C} would be {tax:C}\n");

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}