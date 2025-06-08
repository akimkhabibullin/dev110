/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Programming Assignment 2 Decisions
*    
*    Description: 
*    sdfksjdlfksdlfkjsldkfjlksjdflksjdlfkjlskdjflskdlkfjsldkjflksdjflkjsdlkfjlskdjlksdjlfkjsldkfj
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
    static void Main(String[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Acme Anvils Inc.");
        Console.WriteLine("Supporting the anvil industry for 100 years and counting!!\n");

        // Collect user info
        Console.Write("Number of anvils: ");
        int numberOfAnvils = int.Parse(s: Console.ReadLine());

        Console.Write("Customer's name: ");
        string customerName = Console.ReadLine();

        Console.Write("Street address: ");
        string streetAddress = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State: ");
        string state = Console.ReadLine().ToUpper(); // Ensure state is uppercase for consistency

        Console.Write("Zip: ");
        string zip = Console.ReadLine();

        // Futility Club membership
        Console.Write("Are you a member of the Futility Club? (Y/N): ");
        bool isFutilityClubMember = Console.ReadLine().ToUpper() == "Y";
        string giftMessage = "";

        if (isFutilityClubMember == true)
        {
            // Free gift selection (i wanated to try out using the switch method and its honestly quite usefull and takes a lot less space)
            Console.Write("Choose your free gift: (P) Jet-Propelled Pogo Stick, (B) Jar of ACME Bumble Bees, or (N) None: ");
            string giftChoice = Console.ReadLine().ToUpper();
            switch (giftChoice)
            {
                case "P":
                    giftMessage = "Jet-Propelled Pogo Stick";
                    break;
                case "B":
                    giftMessage = "Jar of ACME Bumble Bees";
                    break;
                default:
                    giftMessage = "None";
                    break;
            }
        }
        // Pause for invoice
        Console.WriteLine("\nPress any key to display invoice...");
        Console.ReadKey();

        // Calculate price per anvil based on quantity
        double pricePerAnvil;
        if (numberOfAnvils >= 20)
        {
            pricePerAnvil = 68.25;
        }
        else if (numberOfAnvils >= 10)
        {
            pricePerAnvil = 70.00;
        }
        else
        {
            pricePerAnvil = 88.50;
        }

        // Calculate subtotal, discount, and tax
        double subtotal = numberOfAnvils * pricePerAnvil;
        double discount = isFutilityClubMember ? subtotal * 0.15 : 0;
        double taxRate = 0.10;
        double tax = (subtotal - discount) * taxRate;

        // Calculate shipping
        double shippingCost = 112 * numberOfAnvils;
        bool isFreeShipping = (state == "CA" || state == "OR") && numberOfAnvils <= 4;

        // Calculate total
        double total = (subtotal - discount) + tax + (isFreeShipping ? 0 : shippingCost);

        // Display invoice
        Console.Clear();
        Console.WriteLine("---------------- INVOICE ----------------");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Address: {streetAddress}, {city}, {state}, {zip}\n");

        Console.WriteLine($"Number of anvils: {numberOfAnvils}");
        Console.WriteLine($"Price per anvil: {pricePerAnvil:C}");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        if (isFutilityClubMember == true)
        {
            Console.WriteLine($"Futility Club Discount (15%): -{discount:C}");
        }

        Console.WriteLine($"Tax (10%): {tax:C}");

        if (!isFreeShipping)
        {
            Console.WriteLine($"Shipping: {shippingCost:C}");
        }
        else
        {
            Console.WriteLine("Shipping: FREE SHIPPING!");
        }
        
        Console.WriteLine($"Total: {total:C}\n");

        // Display free gift message 
        if (isFutilityClubMember == true)
        {
            Console.WriteLine($"BONUS! Along with today’s order, you’ll receive a free {giftMessage}!");
        }
        // Thank you message
        Console.WriteLine("\nThank you for shopping with Acme Anvils!");
        Console.WriteLine("We support your anvil needs, one anvil at a time!\n");

        // End program
        Console.WriteLine("Press any key to end the program...");
        Console.ReadKey();
    }
}