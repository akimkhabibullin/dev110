using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> dwarfs = new List<string>
        {
            "Bashful",
            "Sneezy",
            "Sleepy",
            "Happy",
            "Grumpy",
            "Doc",
            "Dopey"
        };
        Console.WriteLine("Initial list of dwarfs:");
        Console.WriteLine(string.Join(", ", dwarfs));

        Console.WriteLine("\nEnter a new dwarf name to add:");
        string newDwarf = Console.ReadLine();

        dwarfs.Add(newDwarf);

        dwarfs.Sort();

        Console.WriteLine("\nSorted list of dwarfs:");
        Console.WriteLine(string.Join(", ", dwarfs));
    }
}
