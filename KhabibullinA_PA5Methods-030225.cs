using System;



class Program
{
    static void PrintBanner()
    {
        Console.WriteLine("*************************************");
        Console.WriteLine("*****   ACME Anvils Corporation  *****");
        Console.WriteLine("*****         NEW ORDER         *****");
        Console.WriteLine("*************************************");
        Console.WriteLine("Supporting the animation industry for 70 years and counting!");
        Console.WriteLine();
    }

    static void Countdown(int numberOfSeconds)
    {
        for (int i = numberOfSeconds; i > 0; i--)
        {
            Console.WriteLine($"Union break: {i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    static int GetPositiveInt(string prompt)
    {
        int number;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (!int.TryParse(input, out number) || number <= 0)
            {
                Console.WriteLine("***ERROR. Number of anvils must be a positive, whole number.");
            }
        } while (number <= 0);
        return number;
    }

    static string GetValidString(string prompt, int min)
    {
        string input;
        do
        {
            Console.Write($"Please enter {prompt}: ");
            input = Console.ReadLine();
            if (input.Length < min)
            {
                Console.WriteLine($"{prompt} must be at least {min} character{(min == 1 ? "" : "s")} long. Please re-enter. ");
            }
        } while (input.Length < min);
        return input;
    }

    static string GetValidString(string prompt, int min, int max)
    {
        string input;
        do
        {
            Console.Write($"Please enter {prompt}: ");
            input = Console.ReadLine();
            if (input.Length < min || input.Length > max)
            {
                if (min == max)
                {
                    Console.WriteLine($"{prompt} must be exactly {min} characters long. Please re-enter. ");
                }
                else
                {
                    Console.WriteLine($"{prompt} must be between {min} and {max} characters long. Please re-enter. ");
                }
            }
        } while (input.Length < min || input.Length > max);
        return input;
    }

    static string GetValidState(string prompt, string[] sortedStateArray)
    {
        bool valid = false;
        string state;
        do
        {
            state = GetValidString(prompt, 2, 2);
            for (int i = 0; i < sortedStateArray.Length; i++)
            {
                if (state.ToUpper() == sortedStateArray[i])
                {
                    valid = true;
                    break;
                }
            }
            if (!valid)
            {
                Console.WriteLine($"***ERROR. We do not ship to {state}. Please give it another shot: ");
            }
        } while (!valid);
        return state.ToUpper();
    }

    static bool LoyaltyDiscount()
    {
        Console.Write("Are you a member of the Futility Club? (Y/N): ");
        string response = Console.ReadLine().ToUpper();
        if (response == "Y")
        {
            Console.WriteLine("Welcome back, loyal customer!");
            return true;
        }
        Console.WriteLine("What’s wrong with you? That just cost you a 15% discount and an opportunity to win some Invisible Paint. Sad.");
        return false;
    }

    static bool EnterContest(Random chanceGenerator)
    {
        Console.WriteLine("Guess a number between 1 and 5 to win a FREE GIFT!");
        int target = chanceGenerator.Next(1, 6); // Random number 1-5
        int guess = GetPositiveInt("Enter your guess: ");
        if (guess == target)
        {
            Console.WriteLine($"Woo Hoo! You guessed the secret number: {target}!");
            Console.WriteLine("A gallon of ACME Invisible Paint is headed your way!");
            return true;
        }
        Console.WriteLine($"Aww, too bad. You guessed {guess}, but the secret number was {target}. No paint. What a loser. Very sad.");
        return false;
    }

    static decimal GetAnvilPrice(int qty)
    {
        decimal[] prices = { 80.00m, 72.35m, 67.99m }; // Prices for qty ranges: <10, <20, >=20
        int[] thresholds = { 10, 20 }; // Quantity thresholds for price breaks
        for (int i = thresholds.Length - 1; i >= 0; i--)
        {
            if (qty >= thresholds[i])
            {
                return prices[i + 1];
            }
        }
        return prices[0]; // Default for qty < 10
    }

    static decimal CalcAndPrintInvoiceBody(int qty, bool discount, bool promotionPrize)
    {
        decimal pricePerAnvil = GetAnvilPrice(qty);
        decimal subtotal = qty * pricePerAnvil;
        decimal discountAmount = discount ? subtotal * 0.15m : 0m; // 15% discount
        decimal taxable = subtotal - discountAmount;
        decimal tax = taxable * 0.0995m; // 9.95% sales tax
        decimal shipping = 99.00m * qty;
        decimal total = taxable + tax + shipping;

        Console.WriteLine("---------------- INVOICE ----------------");
        Console.WriteLine($"Number of anvils: {qty}");
        Console.WriteLine($"Price per anvil: {pricePerAnvil:C}");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        if (discount)
        {
            Console.WriteLine($"Futility Club Discount (15%): {discountAmount:C}");
        }
        Console.WriteLine($"Tax (9.95%): {tax:C}");
        Console.WriteLine($"Shipping: {shipping:C}");
        Console.WriteLine($"Total: {total:C}");
        if (promotionPrize)
        {
            Console.WriteLine("Congratulations on your fabulous FREE GIFT!");
        }
        Console.WriteLine();

        return total;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            PrintBanner();
            Countdown(3);

            string[] states = { "AK", "WA", "OR", "CA", "AZ", "NM", "CO", "UT" };
            Array.Sort(states);

            string name = GetValidString("name", 1);
            string street = GetValidString("street address", 1);
            string city = GetValidString("city", 1, 20);
            string zip = GetValidString("zip", 5, 5);
            string state = GetValidState("state", states);

            Console.WriteLine("\nShipping to:");
            Console.WriteLine($"{name}");
            Console.WriteLine($"{street}");
            Console.WriteLine($"{city}, {state} {zip}");
            Console.WriteLine();

            int qty = GetPositiveInt("Hi, I'm your name here. How many anvils would you like to order today? ");
            bool discount = LoyaltyDiscount();
            Random rand = new Random();
            bool prize = EnterContest(rand);

            Console.WriteLine("Press any key to display invoice...");
            Console.ReadKey();

            decimal total = CalcAndPrintInvoiceBody(qty, discount, prize);

            Console.WriteLine($"Your total today is {total:C}. Thanks for shopping with Acme!");
            Console.WriteLine("We support your anvil needs, one anvil at a time!");

            Console.Write("\nWould you like to take another order? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y")
                break;

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}