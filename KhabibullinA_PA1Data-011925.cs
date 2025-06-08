/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Graded Exercise: Hello World!
*    
*    Description: 
*    This is a basic Hello World Program
*    It reads input from the keyboard and
*    displays on the screen
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         01/12/2025         Initial Release 
*    1
* 
*/
using System;

class Program
{
    static void Main(String[] args)
    {
        // Display Welcome Message
        Console.WriteLine("Welcome to Acme Anvils Corporation");
        Console.WriteLine("Supporting the animation industry since 1949!!\n");

        // Collect user input
        Console.Write("Number of anvils: ");
        int numberOfAnvils = int.Parse(Console.ReadLine());

        Console.Write("Customer's name: ");
        string customerName = Console.ReadLine();

        Console.Write("Street address: ");
        string streetAddress = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State: ");
        string state = Console.ReadLine();

        Console.Write("Zip: ");
        string zip = Console.ReadLine();

        // Calculate cost
        const double pricePerAnvil = 88.50;
        const double taxRate = 0.095;
        double subtotal = numberOfAnvils * pricePerAnvil;
        double total = subtotal + (subtotal * taxRate);

        // Pause execution
        Console.WriteLine("\nPress any key to display invoice...");
        Console.ReadKey();

        // Display invoice
        Console.Clear();
        Console.WriteLine("---------------- INVOICE ----------------");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Address: {streetAddress}, {city}, {state}, {zip}\n");

        Console.WriteLine($"Number of anvils: {numberOfAnvils}");
        Console.WriteLine($"Price per anvil: {pricePerAnvil:C}");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Tax (9.5%): {subtotal * taxRate:C}");
        Console.WriteLine($"Total: {total:C}\n");

        Console.WriteLine("Thank you for shopping with Acme Anvils!");
        Console.WriteLine("We support your animation needs, one anvil at a time!\n");
        Console.WriteLine("-----------------------------------------");

        // End program
        Console.WriteLine("Press any key to end the program...");
        Console.ReadKey();
    }
}