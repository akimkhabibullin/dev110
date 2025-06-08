/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment:Sum it up with methods
*    
*    Description: 
*    this adds a array of numbers together
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         02/23/2025         Initial Release 
*    1
* 
*/
using System;

class Program
{
    static int SumItUp(int[] numbers)
    {
        // Reverse the array
        Array.Reverse(numbers);

        // Calculate and return the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        // Declare and initialize the first array
        int[] someNumbers = { 1, 2, 3, 4, 5 };

        // Call SumItUp and print the result
        int sum1 = SumItUp(someNumbers);
        string reversedNumbers = String.Join(" + ", someNumbers);
        Console.WriteLine($"First array: {reversedNumbers} = {sum1}");

        // Call SumItUp with a new array inline and print the result
        int sum2 = SumItUp(new int[] { 10, 20, 30 });
        Console.WriteLine($"Sum of the second array is {sum2}.");

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}