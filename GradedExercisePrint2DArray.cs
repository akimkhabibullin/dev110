/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: gradded excercise print 2d array
*    
*    Description: 
*    this makes a 2d array adn prints it
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
        // create the 3x4 array
        int[,] array =
        {
            { 11, 12, 13, 14 },
            { 21, 22, 23, 24 },
            { 31, 32, 33, 34 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Part 1: Print all 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"[{i}, {j}] {array[i, j]}");
            }
        }

        // Print finish
        Console.WriteLine("finish!");
    }
}
