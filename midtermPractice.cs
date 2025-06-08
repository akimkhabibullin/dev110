/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Midterm Practice
*    
*    Description: 
*    this solves 3 problems and is practice for the midterm
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         01/26/2025         Initial Release 
*    1
* 
*/
using System;

class Program
{
    static void Main()
    {
        // Problem 1: Salesperson Calculatioin
        Console.WriteLine("*** PROBLEM 1 ***");
        double totalSales = 0;
        double commissionRate = 0;

        while (true)
        {
            Console.Write("Enter a decimal number or '-999' to quit: ");
            string input = Console.ReadLine();
            double sale;

            if (double.TryParse(input, out sale))
            {
                if (sale == -999)
                {
                    break;
                }
                totalSales += sale;
            }
        }

        if (totalSales > 0)
        {
            if (totalSales >= 1000)
            {
                commissionRate = 0.15;
            }
            else if (totalSales >= 500)
            {
                commissionRate = 0.10;
            }
            else
            {
                commissionRate = 0.05;
            }
        }

        double commission = totalSales * commissionRate;
        double totalEarnings = totalSales + commission;

        Console.WriteLine("Your sales total is " + totalSales.ToString("C") + ", so your commission rate is " + (commissionRate * 100) + "%");
        Console.WriteLine("Your total commission is " + commission.ToString("C") + ".");
        Console.WriteLine("Your total earnings are " + totalEarnings.ToString("C") + ".");

        // Problem 2: Planet position
        Console.WriteLine("\n*** PROBLEM 2 ***");
        Console.Write("Enter the position of a planetary body: ");
        int position = Convert.ToInt32(Console.ReadLine());
        string message;

        switch (position)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                message = "The object at position " + position + " is an inner planet.";
                break;
            case 5:
            case 6:
            case 7:
            case 8:
                message = "The object at position " + position + " is an outer planet.";
                break;
            case 9:
                message = "The object at position 9 is not a planet any more.";
                break;
            default:
                if (position >= 10)
                {
                    message = "The object at position " + position + " is beyond Neptune, so not a planet.";
                }
                else
                {
                    message = "The object at position " + position + " is invalid.";
                }
                break;
        }
        Console.WriteLine(message);

        // Problem 3: string length
        Console.WriteLine("\n*** PROBLEM 3 ***");
        Console.Write("Enter a string: ");
        string prevString = Console.ReadLine();
        Console.WriteLine("That string is " + prevString.Length + " character(s) long.");

        while (true)
        {
            Console.Write("Good. Now enter a longer string: ");
            string newString = Console.ReadLine();
            Console.WriteLine("That string is " + newString.Length + " character(s) long.");

            if (newString.Length <= prevString.Length)
            {
                Console.WriteLine("Sadly, that was not longer than the previous string.");
            }
            prevString = newString;
        }
    }
}

