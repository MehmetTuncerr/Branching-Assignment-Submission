using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Quick Ship Services. Please follow the instructions below.");

        // Get package weight
        Console.WriteLine("Enter the weight of the package:");
        float weight = float.Parse(Console.ReadLine());

        // Check if package is too heavy
        if (weight > 45)
        {
            Console.WriteLine("Sorry, the package is too heavy for shipping. Have a great day!");
            return;
        }

        // Get package dimensions
        Console.WriteLine("Enter the package width:");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the package height:");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if package is too large
        if (width + height + length > 55)
        {
            Console.WriteLine("Sorry, the package exceeds the size limit and cannot be shipped.");
            return;
        }

        // Calculate shipping cost
        float cost = (width * height * length * weight) / 120;

        // Display the quote
        Console.WriteLine($"Your estimated shipping cost is: ${cost:F2}");
        Console.WriteLine("Thank you for choosing Quick Ship Services!");
    }
}
