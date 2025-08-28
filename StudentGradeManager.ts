/**
 * STARTER CODE - This class violates the Single Responsibility Principle
 * Your task: Refactor this class to follow SRP by extracting separate responsibilities
 * 
 * Requires TypeScript 5.0+
 */

export class StudentGradeManager {
    
    public processStudent(name: string, scores: number[]): void {
        if (!name || name.trim() === "") {
            console.log("Error: Student name cannot be empty");
            return;
        }
        
        if (!scores || scores.length === 0) {
            console.log("Error: No scores provided");
            return;
        }
        
        for (const score of scores) {
            if (score < 0 || score > 100) {
                console.log(`Error: Invalid score ${score}. Must be between 0-100`);
                return;
            }
        }

        const average = scores.reduce((sum, score) => sum + score, 0) / scores.length;
        
        let letterGrade: string;
        if (average >= 90) {
            letterGrade = "A";
        } else if (average >= 80) {
            letterGrade = "B";
        } else if (average >= 70) {
            letterGrade = "C";
        } else if (average >= 60) {
            letterGrade = "D";
        } else {
            letterGrade = "F";
        }

        console.log("=== STUDENT REPORT ===");
        console.log(`Student: ${name}`);
        console.log(`Scores: ${scores.join(", ")}`);
        console.log(`Average: ${average.toFixed(2)}`);
        console.log(`Letter Grade: ${letterGrade}`);
        console.log(`Status: ${letterGrade === "F" ? "FAILING" : "PASSING"}`);
        console.log("=====================");
    }
}

// Test the StudentGradeManager
function main(): void {
    const manager = new StudentGradeManager();
    
    console.log("Testing Student Grade Manager\n");
    
    // Test case 1: Valid student with good grades
    manager.processStudent("Alice Johnson", [85, 92, 78, 96, 88]);
    console.log();
    
    // Test case 2: Valid student with failing grades
    manager.processStudent("Bob Smith", [45, 55, 52, 48, 50]);
    console.log();
    
    // Test case 3: Invalid input - empty name
    manager.processStudent("", [90, 85]);
    console.log();
    
    // Test case 4: Invalid input - invalid score
    manager.processStudent("Charlie Brown", [105, 85]);
    console.log();
    
    // Test case 5: Invalid input - no scores
    manager.processStudent("Diana Prince", []);
    

}

// Run the main function if this file is executed directly
// In ES modules, we check if this is the main module by comparing import.meta.url
if (import.meta.url === `file://${process.argv[1]}` || process.argv[1]?.endsWith('StudentGradeManager.js')) {
    main();
}
