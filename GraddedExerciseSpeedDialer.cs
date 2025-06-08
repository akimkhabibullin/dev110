/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: gradded excercise speed dialer
*    
*    Description: 
*    this lets you call people and yeah
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
        string[] names = { "Arnold", "Sly", "Dwayne", "Vin", "JCVD", "Steven" };
        string[] numbers = { "213-222-1111", "213-111-1111", "213-444-1111", "213-666-1111", "213-321-1111", "213-978-1111" };

        for (int i = 0; i < names.Length; i++)
            Console.WriteLine($"Slot {i + 1}: {names[i]} {numbers[i]}");

        while (true)
        {
            Console.Write("\nWho would you like to call? ");
            string input = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower() == input.ToLower())
                {
                    Console.WriteLine($"Calling {names[i]} at {numbers[i]}");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Not found.");

            Console.Write("Look up another? (y/n) ");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }
    }
}
