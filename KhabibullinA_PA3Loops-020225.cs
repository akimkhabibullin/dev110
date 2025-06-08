/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2021
*
*    Programmer: Akim Khabibullin
*    Assignment: Programming Assignment 3 Loops
*    
*    Description: 
*    this version uses loops to do a bunch of stuff like adda timer at the start and ask if you want to order again
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         01/26/2025         Initial Release 
*    1
* 
*/
using System;
using System.Threading;

class Program
{
    static void Main(String[] args)
    {
        while (true)
        {
            // Countdown before taking order
            for (int i = 3; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Taking next order in {i}...");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("NEW ORDER!");
            Console.Beep();

            // Welcome message
            Console.WriteLine("Welcome to Acme Anvils Inc.");
            Console.WriteLine("Supporting the anvil industry for 100 years and counting!!\n");

            // Collect user info
            int numberOfAnvils;
            while (true)
            {
                Console.Write("Number of anvils: ");
                if (int.TryParse(Console.ReadLine(), out numberOfAnvils) && numberOfAnvils > 0)
                    break;
                Console.WriteLine("Number of anvils must be a positive, whole number.");
            }

            string customerName;
            do
            {
                Console.Write("Customer's name: ");
                customerName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(customerName));

            Console.Write("Street address: ");
            string streetAddress = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();

            string state;
            string[] validStates = { "AK", "WA", "OR", "CA", "AZ", "NM", "CO", "UT" };
            while (true)
            {
                Console.Write("State: ");
                state = Console.ReadLine().ToUpper();
                if (Array.Exists(validStates, s => s == state))
                    break;
                Console.WriteLine($"We do not ship to {state}.");
            }

            string zip;
            while (true)
            {
                Console.Write("Zip: ");
                zip = Console.ReadLine();
                if (zip.Length == 5)
                    break;
                Console.WriteLine("Zip code must be 5 characters long.");
            }

            // Futility Club membership
            Console.Write("Are you a member of the Futility Club? (Y/N): ");
            bool isFutilityClubMember = Console.ReadLine().ToUpper() == "Y";

            if (isFutilityClubMember)
            {
                Console.WriteLine("Excellent! You'll receive an AMAZING 15% discount on today's purchase! What’s more, as a valued member of our loyalty program, you’ll have a chance to win a bonus gift in our exciting Members-Only Gallon of Invisible Paint contest! Pick a number between 1 and 5!");
                int secretNumber = new Random().Next(1, 6);
                int userGuess;
                if (int.TryParse(Console.ReadLine(), out userGuess) && userGuess >= 1 && userGuess <= 5)
                {
                    if (userGuess == secretNumber)
                        Console.WriteLine($"Woo hoo! You guessed the secret number: {userGuess}. A gallon of ACME Invisible Paint is headed your way!");
                    else
                        Console.WriteLine($"Aww, too bad. You guessed {userGuess}, but the secret number was {secretNumber}. No paint. What a loser. Very sad.");
                }
                else
                {
                    Console.WriteLine("That’s not a number between 1 and 5. What an ultra-maroon! Still, we value your loyalty.");
                }
            }
            else
            {
                Console.WriteLine("What’s wrong with you? That just cost you a 15% discount and an opportunity to win a gallon of invisible paint. Sad.");
            }

            // Calculate price per anvil based on quantity
            double pricePerAnvil = numberOfAnvils >= 20 ? 67.99 : numberOfAnvils >= 10 ? 72.35 : 80.00;
            double subtotal = numberOfAnvils * pricePerAnvil;
            double discount = isFutilityClubMember ? subtotal * 0.15 : 0;
            double taxRate = 0.0995;
            double tax = (subtotal - discount) * taxRate;
            double shippingCost = 99.00 * numberOfAnvils;
            double total = (subtotal - discount) + tax + shippingCost;

            Console.WriteLine("Press any key to display invoice.");
            Console.ReadKey();

            // Display invoice
            Console.Clear();
            Console.WriteLine("---------------- INVOICE ----------------");
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Address: {streetAddress}, {city}, {state}, {zip}\n");
            Console.WriteLine($"Number of anvils: {numberOfAnvils}");
            Console.WriteLine($"Price per anvil: {pricePerAnvil:C}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            if (isFutilityClubMember)
                Console.WriteLine($"Futility Club Discount (15%): -{discount:C}");
            Console.WriteLine($"Tax (9.95%): {tax:C}");
            Console.WriteLine($"Shipping: {shippingCost:C}");
            Console.WriteLine($"Total: {total:C}\n");

            Console.WriteLine("Thank you for shopping with Acme Anvils!");
            Console.WriteLine("We support your anvil needs, one anvil at a time!\n");

            Console.Write("Would you like to take another order? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y")
                break;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
