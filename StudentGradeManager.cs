using System;
using System.Collections.Generic;
using System.Linq;

namespace SRPWorkshop
{
    /// <summary>
    /// STARTER CODE - This class violates the Single Responsibility Principle
    /// Your task: Refactor this class to follow SRP by extracting separate responsibilities
    /// </summary>
    public class StudentGradeManager
    {
        public void ProcessStudent(string name, List<int> scores)
        {
            // Responsibility 1: Input Validation
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Student name cannot be empty");
                return;
            }
            
            if (scores == null || scores.Count == 0)
            {
                Console.WriteLine("Error: No scores provided");
                return;
            }
            
            foreach (var score in scores)
            {
                if (score < 0 || score > 100)
                {
                    Console.WriteLine($"Error: Invalid score {score}. Must be between 0-100");
                    return;
                }
            }

            // Responsibility 2: Grade Calculation
            double average = scores.Sum() / (double)scores.Count;
            
            string letterGrade;
            if (average >= 90) letterGrade = "A";
            else if (average >= 80) letterGrade = "B";
            else if (average >= 70) letterGrade = "C";
            else if (average >= 60) letterGrade = "D";
            else letterGrade = "F";

            // Responsibility 3: Report Formatting and Display
            Console.WriteLine("=== STUDENT REPORT ===");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Scores: {string.Join(", ", scores)}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
            Console.WriteLine($"Status: {(letterGrade == "F" ? "FAILING" : "PASSING")}");
            Console.WriteLine("=====================");
        }
    }

    /// <summary>
    /// Program class to test the StudentGradeManager
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var manager = new StudentGradeManager();
            
            Console.WriteLine("Testing Student Grade Manager\n");
            
            // Test case 1: Valid student with good grades
            manager.ProcessStudent("Alice Johnson", new List<int> { 85, 92, 78, 96, 88 });
            Console.WriteLine();
            
            // Test case 2: Valid student with failing grades
            manager.ProcessStudent("Bob Smith", new List<int> { 45, 55, 52, 48, 50 });
            Console.WriteLine();
            
            // Test case 3: Invalid input - empty name
            manager.ProcessStudent("", new List<int> { 90, 85 });
            Console.WriteLine();
            
            // Test case 4: Invalid input - invalid score
            manager.ProcessStudent("Charlie Brown", new List<int> { 105, 85 });
            Console.WriteLine();
            
            // Test case 5: Invalid input - no scores
            manager.ProcessStudent("Diana Prince", new List<int>());
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
