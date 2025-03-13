# Student Grade Calculator

This is a simple console application built using .NET that calculates a student's average score and assigns a grade based on their marks in Math, Science, and English.

## Features
- It takes input for the student's name and scores in Math, Science, and English.
- Validates input to ensure scores are between 0 and 100.
- Calculates the average score and assigns a grade (A, B, C, D, or F).
- Displays the student's details, average score, and grade.

## How to Run the Project

1. **Prerequisites**:
   - Install the [.NET SDK](https://dotnet.microsoft.com/download).

2. **Clone the Repository**:
   - Clone this repository to your local machine:
     ```bash
     git clone https://github.com/your-username/StudentGradeCalculator.git
     ```

3. **Navigate to the Project Folder**:
   - Open the terminal and navigate to the project folder:
     ```bash
     cd StudentGradeCalculator
     ```

4. **Run the Application**:
   - Run the following command to start the application:
     ```bash
     dotnet run
     ```

5. **Follow the Prompts**:
   - Enter the student's name and scores when prompted.
   - The program will display the student's details, average score, and grade.

## Example Output
Welcome to the Student Grade Calculator!
Enter student's name: Prasad
Enter Math score (0-100): 95
Enter Science score (0-100): 85
Enter English score (0-100): 90

Student Name: Prasad
Math Score: 95
Science Score: 85
English Score: 90
Average Score: 90.00
Grade: A


## Code Structure

- **Student Class**:
  - Contains properties for the student's name and scores.
  - Methods to calculate the average score and determine the grade.

- **Main Program**:
  - Handles user input and creates a `Student` object.
  - Displays the student's details and grade.

## Technologies Used
- .NET 9.0
- C#

## Author
- Vamsi Prasad