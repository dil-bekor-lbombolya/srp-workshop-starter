# Single Responsibility Principle (SRP) Workshop

## Overview
This workshop is designed to help you understand and practice the Single Responsibility Principle, one of the core SOLID principles. You'll refactor TypeScript code that violates SRP into a clean, maintainable solution.

## Exercise: Student Grade Calculator

### Current Problem
The `StudentGradeManager` class in `StudentGradeManager.ts` violates the Single Responsibility Principle by handling multiple responsibilities in a single class.

### Your Tasks

#### Task 1: Identify Responsibilities and Refactor (10 minutes)
Look at the `processStudent` method in `StudentGradeManager` class and identify the different responsibilities it handles. 

**Questions to consider:**
- What different "reasons to change" can you identify?
- What separate concerns are mixed together?
- How many distinct jobs is this class doing?

**Hints:**
- Think about what each class should be responsible for
- Consider how you might want to test each responsibility separately
- Consider how you might want to extend or modify each responsibility independently

### Expected Benefits
After completing this exercise, your code should demonstrate:

✅ **Single Responsibility Principle**: Each class has one clear reason to change  
✅ **Improved Testability**: Each component can be unit tested in isolation  
✅ **Better Maintainability**: Changes to one responsibility don't affect others  
✅ **Enhanced Extensibility**: Easy to add new implementations (e.g., different grading scales, report formats)  
✅ **Loose Coupling**: Components depend on abstractions, not concrete implementations  

### Discussion Questions (After Completion)
1. **Testing**: How would you unit test the grade calculation logic separately from validation?
2. **Extension**: How would you add a new grading scale (A+, A, A-, B+, etc.)?
3. **Variation**: How would you create a JSON report format instead of console output?
4. **Validation**: How would you add new validation rules (e.g., minimum number of scores)?
5. **Reusability**: How could you reuse the grade calculator in a different application?

### Running the Code
**Requirements**: Node.js 18+ and TypeScript 5.0+

#### Quick Start:
```bash
# Install dependencies
npm install

# Run the starter code (auto-compiles and runs)
npm run dev
```

#### Manual Build & Run:
```bash
# Compile TypeScript to JavaScript
npm run build

# Run the compiled starter code
npm run start:starter

```
Happy coding! 🚀
