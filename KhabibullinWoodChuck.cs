/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: part 2 of programming assignment 4 arrays 
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

class WoodchuckSimulator
{
    const int MaxWoodchucks = 100;
    const int MaxDays = 10;

    static void Main()
    {
        int numWoodchucks = 0, numDays = 0;
        bool validInput = false;

        // Display the banner
        Console.WriteLine("***************** ACME Industries Rodent Sciences Division *****************");
        Console.WriteLine("* WOODCHUCK WOOD CHUCKING SIMULATION v. 2.0 *");
        Console.WriteLine("* One row per woodchuck, one column per day *");
        Console.WriteLine("****************************************************************************");

        // Ask the user for the number of woodchucks + checks if valid
        while (!validInput)
        {
            Console.Write("Enter number of woodchucks for this simulation (1-100): ");
            validInput = int.TryParse(Console.ReadLine(), out numWoodchucks);
            if (validInput && numWoodchucks >= 1 && numWoodchucks <= MaxWoodchucks)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                validInput = false;
            }
        }

        // Ask the user for the number of days + checks if valid
        validInput = false;
        while (!validInput)
        {
            Console.Write("Enter number of days for this simulation (1-10): ");
            validInput = int.TryParse(Console.ReadLine(), out numDays);
            if (validInput && numDays >= 1 && numDays <= MaxDays)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                validInput = false;
            }
        }

        // Create a 2D array to store the wood chucking data
        Random rand = new Random();
        int[,] woodchuckData = new int[numWoodchucks, numDays];

        // Fill the array with random values between 1 and 50
        for (int i = 0; i < numWoodchucks; i++)
        {
            for (int j = 0; j < numDays; j++)
            {
                woodchuckData[i, j] = rand.Next(1, 51);
            }
        }

        // Print the header for the table
        Console.Write("    ");
        for (int day = 1; day <= numDays; day++)
        {
            Console.Write($"{day,4}");
        }
        Console.WriteLine();
        Console.WriteLine("   " + new string('_', numDays * 5));

        // Print the rows of data (woodchucks and their chucking activity)
        int totalWoodChucked = 0;
        for (int i = 0; i < numWoodchucks; i++)
        {
            Console.Write($"{i + 1,2} |");
            int rowTotal = 0;
            for (int j = 0; j < numDays; j++)
            {
                Console.Write($"{woodchuckData[i, j],4}");
                rowTotal += woodchuckData[i, j];
                totalWoodChucked += woodchuckData[i, j];
            }
            Console.WriteLine($" | {rowTotal,4}");
        }

        // Print the total row
        Console.WriteLine("   " + new string(' ', 3) + new string('_', numDays * 5));
        Console.Write("Total ");
        int dailyTotal = 0;
        for (int j = 0; j < numDays; j++)
        {
            for (int i = 0; i < numWoodchucks; i++)
            {
                dailyTotal += woodchuckData[i, j];
            }
            Console.Write($"{dailyTotal,4}");
            dailyTotal = 0;
        }
        Console.WriteLine();

        // Print the total wood chucked and the average per woodchuck
        float averageChuckage = (float)totalWoodChucked / (numWoodchucks * numDays);
        Console.WriteLine($"\nTotal wood chucked: {totalWoodChucked}");
        Console.WriteLine($"Average woodchuck chuckage: {averageChuckage:F2}");
    }
}
/*********************************************************************
* Test Cases:
* Test Case 1: User inputs valid woodchucks and days
* Input: 10 woodchucks, 5 days
* Expected Output: A 10x5 matrix of wood chucked values, correct row totals, column totals and average values displayed at the end.
*
* Test Case 2: User inputs a number of woodchucks that exceeds the limit (greater than 100)
* Input: 150 woodchucks, 5 days
* Expected Output: An error message prompting the user to enter a number between 1 and 100 and the program will ask for valid input again.
*
* Test Case 3: User inputs a number of days that exceeds the limit (greater than 10)
* Input: 10 woodchucks, 15 days
* Expected Output: An error message prompting the user to enter a number between 1 and 10 and the program will ask for valid input again.
*
* Test Case 4: User inputs a non-numeric value for woodchucks
* Input: "abc" for woodchucks, 5 days
* Expected Output: An error message prompting the user to enter a valid number for woodchucks and the program will ask for valid input again.
*
* Test Case 5: User inputs a non-numeric value for days
* Input: 10 woodchucks, "xyz" for days
* Expected Output: An error message prompting the user to enter a valid number for days and the program will ask for valid input again.
*
* Test Case 6: User inputs 1 woodchuck and 1 day
* Input: 1 woodchuck, 1 day
* Expected Output: A 1x1 matrix, total wood chucked of the random value (between 1 and 50), and the average value (the same as the total).
*
* Test Case 7: User inputs the maximum number of woodchucks and days
* Input: 100 woodchucks, 10 days
* Expected Output: A 100x10 matrix, row totals, column totals, total wood chucked, and average values displayed at the end, with appropriate formatting and computation.
*
* Test Case 8: User decides to run another simulation after completion
* Input: "y" (to start a new simulation)
* Expected Output: Program prompts the user for new input (woodchucks, days, etc.) and begins the simulation again from the start.
*
* Test Case 9: User decides not to run another simulation
* Input: "n" (to exit the program)
* Expected Output: Program exits 
*********************************************************************/
