"""
STARTER CODE - This class violates the Single Responsibility Principle
Your task: Refactor this class to follow SRP by extracting separate responsibilities

Requires Python 3.12+
"""

import sys

# Ensure Python 3.12+ is being used
if sys.version_info < (3, 12):
    print(f"This code requires Python 3.12+. You are using Python {sys.version}")
    sys.exit(1)


class StudentGradeManager:
    """
    This class violates SRP by handling multiple responsibilities:
    - Input validation
    - Grade calculation  
    - Report formatting and display
    """
    
    def process_student(self, name: str, scores: list[int]) -> None:
        """Process a student's scores and display their grade report"""
        
        # Responsibility 1: Input Validation
        if not name or name.strip() == "":
            print("Error: Student name cannot be empty")
            return
        
        if not scores or len(scores) == 0:
            print("Error: No scores provided")
            return
        
        for score in scores:
            if score < 0 or score > 100:
                print(f"Error: Invalid score {score}. Must be between 0-100")
                return
        
        # Responsibility 2: Grade Calculation
        average = sum(scores) / len(scores)
        
        # Using Python 3.10+ match/case for cleaner grade logic
        match average:
            case avg if avg >= 90:
                letter_grade = "A"
            case avg if avg >= 80:
                letter_grade = "B"
            case avg if avg >= 70:
                letter_grade = "C"
            case avg if avg >= 60:
                letter_grade = "D"
            case _:
                letter_grade = "F"
        
        # Responsibility 3: Report Formatting and Display
        print("=== STUDENT REPORT ===")
        print(f"Student: {name}")
        print(f"Scores: {', '.join(map(str, scores))}")
        print(f"Average: {average:.2f}")
        print(f"Letter Grade: {letter_grade}")
        print(f"Status: {'FAILING' if letter_grade == 'F' else 'PASSING'}")
        print("=====================")


def main():
    """Test the StudentGradeManager"""
    manager = StudentGradeManager()
    
    print("Testing Student Grade Manager\n")
    
    # Test case 1: Valid student with good grades
    manager.process_student("Alice Johnson", [85, 92, 78, 96, 88])
    print()
    
    # Test case 2: Valid student with failing grades
    manager.process_student("Bob Smith", [45, 55, 52, 48, 50])
    print()
    
    # Test case 3: Invalid input - empty name
    manager.process_student("", [90, 85])
    print()
    
    # Test case 4: Invalid input - invalid score
    manager.process_student("Charlie Brown", [105, 85])
    print()
    
    # Test case 5: Invalid input - no scores
    manager.process_student("Diana Prince", [])
    

if __name__ == "__main__":
    main()
