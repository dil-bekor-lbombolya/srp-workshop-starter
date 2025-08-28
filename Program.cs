using SRPWorkshop;

var manager = new StudentGradeManager();

Console.WriteLine("Testing Student Grade Manager\n");

// Test case 1: Valid student with good grades
manager.ProcessStudent("Alice Johnson", new[] { 85, 92, 78, 96, 88 });
Console.WriteLine();

// Test case 2: Valid student with failing grades
manager.ProcessStudent("Bob Smith", new[] { 45, 55, 52, 48, 50 });
Console.WriteLine();

// Test case 3: Invalid input - empty name
manager.ProcessStudent("", new[] { 90, 85 });
Console.WriteLine();

// Test case 4: Invalid input - invalid score
manager.ProcessStudent("Charlie Brown", new[] { 105, 85 });
Console.WriteLine();

// Test case 5: Invalid input - no scores
manager.ProcessStudent("Diana Prince", Array.Empty<int>());
