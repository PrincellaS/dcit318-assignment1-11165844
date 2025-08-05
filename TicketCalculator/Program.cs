using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Movie Theater Ticket Price Calculator ===");
            Console.WriteLine();
            
            // Display pricing information
            Console.WriteLine("Ticket Prices:");
            Console.WriteLine("Regular Price: GHC10");
            Console.WriteLine("Senior (65+) or Child (12 and under): GHC7");
            Console.WriteLine();
            
            // Prompt user for age input
            Console.Write("Enter your age: ");
            
            // Read and validate input
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                // Validate age (assuming reasonable age range)
                if (age >= 0 && age <= 120)
                {
                    // Calculate ticket price
                    decimal ticketPrice = CalculateTicketPrice(age);
                    string category = GetAgeCategory(age);
                    
                    // Display result
                    Console.WriteLine();
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Category: {category}");
                    Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid age.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid age (whole number).");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static decimal CalculateTicketPrice(int age)
        {
            // Check if customer qualifies for discount
            if (age <= 12 || age >= 65)
            {
                return 7.00m; // Discounted price
            }
            else
            {
                return 10.00m; // Regular price
            }
        }
        
        static string GetAgeCategory(int age)
        {
            if (age <= 12)
                return "Child";
            else if (age >= 65)
                return "Senior Citizen";
            else
                return "Regular";
        }
    }
}