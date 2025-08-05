using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine();
            
            // Prompt user for grade input
            Console.Write("Enter a numerical grade (0-100): ");
            
            // Read and validate input
            if (double.TryParse(Console.ReadLine(), out double grade))
            {
                // Validate grade range
                if (grade >= 0 && grade <= 100)
                {
                    // Determine letter grade
                    string letterGrade = GetLetterGrade(grade);
                    
                    // Display result
                    Console.WriteLine($"Grade: {grade}");
                    Console.WriteLine($"Letter Grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid numerical grade.");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static string GetLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
}