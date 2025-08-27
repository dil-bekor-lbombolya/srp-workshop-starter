// Modern C# 10+ with file-scoped namespace
namespace SRPWorkshop;

/// <summary>
/// STARTER CODE - This class violates the Single Responsibility Principle
/// Your task: Refactor this class to follow SRP by extracting separate responsibilities
/// 
/// Uses modern C# 10+ features:
/// - File-scoped namespaces
/// - Pattern matching for grade calculation
/// - Target-typed new expressions
/// - Global using statements
/// </summary>
public class StudentGradeManager
{
    public void ProcessStudent(string name, IReadOnlyList<int> scores)
    {
        // Responsibility 1: Input Validation
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Error: Student name cannot be empty");
            return;
        }
        
        if (scores is null or { Count: 0 })
        {
            Console.WriteLine("Error: No scores provided");
            return;
        }
        
        // Modern pattern matching for validation
        foreach (var score in scores)
        {
            if (score is < 0 or > 100)
            {
                Console.WriteLine($"Error: Invalid score {score}. Must be between 0-100");
                return;
            }
        }

        // Responsibility 2: Grade Calculation
        var average = scores.Average();
        
        // Modern pattern matching with switch expression
        var letterGrade = average switch
        {
            >= 90 => "A",
            >= 80 => "B", 
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        // Responsibility 3: Report Formatting and Display
        Console.WriteLine("=== STUDENT REPORT ===");
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Scores: {string.Join(", ", scores)}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
        Console.WriteLine($"Status: {(letterGrade is "F" ? "FAILING" : "PASSING")}");
        Console.WriteLine("=====================");
    }
}
