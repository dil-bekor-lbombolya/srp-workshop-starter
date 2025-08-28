namespace SRPWorkshop;

/// <summary>
/// STARTER CODE - This class violates the Single Responsibility Principle
/// Your task: Refactor this class to follow SRP by extracting separate responsibilities
/// </summary>
public class StudentGradeManager
{
    public void ProcessStudent(string name, IReadOnlyList<int> scores)
    {
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
        
        foreach (var score in scores)
        {
            if (score is < 0 or > 100)
            {
                Console.WriteLine($"Error: Invalid score {score}. Must be between 0-100");
                return;
            }
        }

        var average = scores.Average();
        
        var letterGrade = average switch
        {
            >= 90 => "A",
            >= 80 => "B", 
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine("=== STUDENT REPORT ===");
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Scores: {string.Join(", ", scores)}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
        Console.WriteLine($"Status: {(letterGrade is "F" ? "FAILING" : "PASSING")}");
        Console.WriteLine("=====================");
    }
}
