/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Graded Exercise Compare Three Numbers
*    
*    Description: 
*    This program reads three integers from the user and uses nested if and else statements to check if theri equal to eachother.
*    It prints a message showing whether all three are equal, only two are equal, or no two numbers are equal.
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         01/26/2025         Initial Release 
*    1
* 
*/
using System;
class ConsoleApp4
{
    public static void Main(String[] args)
    {
        //read three numbers from  console
        //here i learned that i have to use int.parse() to turn the line the user gave into a int because ReadLine() holds it as a string.
        //if i was to instead use for example:    string num4 = Console.ReadLine();  I would then have to use ".equals" in the if statements after because i would be comparing twp strings
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(s: Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = int.Parse(Console.ReadLine());

        // check for equality
        if (num1 == num2)
        {
            if (num1 == num3)
            {
                Console.WriteLine("All three are equal");
            }
            else
            {
                Console.WriteLine("Only the first and second are equal");
            }
        }
        else
        {
            if (num1 == num3)
            {
                Console.WriteLine("Only the first and third are equal");
            }
            else
            {
                if (num2 == num3)
                {
                    Console.WriteLine("Only the second and third are equal");
                }
                else
                {
                    Console.WriteLine("No two numbers are equal");
                }
            }
        }
    }
}
