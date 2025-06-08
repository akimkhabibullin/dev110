/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: part 1 of programming assignment 4 arrays 
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

class Program
{
    const int DEFAULT_ROLLS = 100000;

    static void Main()
    {
        Console.WriteLine("******************* ACME Industries Simulation Division ********************");
        Console.WriteLine("* Dice Rolling Simulation v. 1.1 *");
        Console.WriteLine("****************************************************************************");

        bool runAgain;
        do
        {
            int numberOfRolls = GetNumberOfRolls();
            int[] rollCounts = new int[11]; 
            Random random = new Random();

            // Simulate rolling dice
            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll = random.Next(1, 7) + random.Next(1, 7);
                rollCounts[roll - 2]++;
            }

            // Print results
            Console.WriteLine("\nRoll    Count    Percentage");
            for (int i = 0; i < rollCounts.Length; i++)
            {
                double percentage = ((double)rollCounts[i] / numberOfRolls) * 100;
                Console.WriteLine("{0,2} {1,10} {2,10:P2}", i + 2, rollCounts[i], percentage / 100);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total {0,10} {1,10:P0}", numberOfRolls, 1.0);

            Console.Write("Would you like to run another simulation? (y/n): ");
            runAgain = Console.ReadLine().Trim().ToLower() == "y";
        } while (runAgain);
    }

    static int GetNumberOfRolls()
    {
        Console.Write("\nHow many rolls would you like to simulate? >> ");
        if (int.TryParse(Console.ReadLine(), out int rolls) && rolls > 0)
        {
            return rolls;
        }
        return DEFAULT_ROLLS;
    }
}
/*********************************************************************
* Test Cases:
* 
* Test Case 1: User inputs 100 rolls
* Input: 100
* Expected Output: Sum of counts should be 100, each roll (2-12) has some occurrence
*
* Test Case 2: User inputs a negative number
* Input: -50
* Expected Output: Default 100000 rolls are used, sum of counts should be 100000
*
* Test Case 3: User inputs a non-numeric value
* Input: abc
* Expected Output: Default 100000 rolls are used, sum of counts should be 100000
*
* Test Case 4: User inputs a very large number
* Input: 1000000
* Expected Output: Sum of counts should be 1000000, distribution similar to probability
*
* Test Case 5: User chooses to run another simulation
* Input: y
* Expected Output: Program restarts with new input prompt
*
* Test Case 6: User chooses not to run another simulation
* Input: n
* Expected Output: Program exits
*********************************************************************/
