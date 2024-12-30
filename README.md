# Student Management Application with C#

This repository contains solutions for advanced programming tasks written in C#. The project focuses on implementing fundamental operations and enhancing existing methods without relying on built-in functionalities, encouraging a deeper understanding of algorithms and problem-solving.

## 📋 Project Tasks

### Part A: Math and String Operations
1. **Custom Power Method**
   - Implemented a method to calculate powers of integers (`Math.Pow`) for positive values without using the `Math` class.

2. **Custom Substring Method**
   - Developed a `Substring` method that accepts two parameters (start index and length) and replicates the behavior of the built-in `Substring` method without using `System` string functions.

---

### Part B: Enhanced Student Management System
The following features were added to a pre-existing student management application:

1. **Enhanced Student Addition**
   - Displays the sequence number of the student during input.
   - Automatically formats names and surnames to proper case (first letter capitalized, others lowercase).
   - Prevents duplicate student numbers by prompting for re-entry.

2. **Improved Student Deletion**
   - Displays a message if there are no students to delete before asking for input.

3. **Improved Student Listing**
   - Displays students' information aligned properly using `PadLeft` and `PadRight` for formatting.
   - Skips headers if there are no students to list.

4. **User Input Validation**
   - Added a `SecimAl` method to handle user menu selection with error handling for up to 10 invalid attempts. Ends the program with a message if the limit is exceeded.

5. **Program Exit**
   - Ensures a graceful exit from the program with the `Environment.Exit` method.
 
