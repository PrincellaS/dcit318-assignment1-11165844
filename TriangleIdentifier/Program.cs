using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine();
            Console.WriteLine("Enter the three sides of a triangle to determine its type:");
            Console.WriteLine();
            
            try
            {
                // Get the three sides from user
                Console.Write("Enter the length of side 1: ");
                double side1 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter the length of side 2: ");
                double side2 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter the length of side 3: ");
                double side3 = Convert.ToDouble(Console.ReadLine());
                
                // Validate that sides can form a triangle
                if (IsValidTriangle(side1, side2, side3))
                {
                    // Determine triangle type
                    string triangleType = GetTriangleType(side1, side2, side3);
                    
                    // Display results
                    Console.WriteLine();
                    Console.WriteLine($"Side 1: {side1}");
                    Console.WriteLine($"Side 2: {side2}");
                    Console.WriteLine($"Side 3: {side3}");
                    Console.WriteLine($"Triangle Type: {triangleType}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: The given sides cannot form a valid triangle.");
                    Console.WriteLine("The sum of any two sides must be greater than the third side.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Error: Please enter valid numerical values for all sides.");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            // Check if all sides are positive
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                return false;
            
            // Check triangle inequality theorem
            // The sum of any two sides must be greater than the third side
            return (side1 + side2 > side3) && 
                   (side1 + side3 > side2) && 
                   (side2 + side3 > side1);
        }
        
        static string GetTriangleType(double side1, double side2, double side3)
        {
            // Check for equilateral triangle (all sides equal)
            if (Math.Abs(side1 - side2) < 0.001 && 
                Math.Abs(side2 - side3) < 0.001 && 
                Math.Abs(side1 - side3) < 0.001)
            {
                return "Equilateral";
            }
            // Check for isosceles triangle (two sides equal)
            else if (Math.Abs(side1 - side2) < 0.001 || 
                     Math.Abs(side2 - side3) < 0.001 || 
                     Math.Abs(side1 - side3) < 0.001)
            {
                return "Isosceles";
            }
            // Otherwise, it's scalene (no sides equal)
            else
            {
                return "Scalene";
            }
        }
    }
}