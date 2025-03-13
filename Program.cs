using System;

public class Student
{

    public string Name;
    public double MathScore;
    public double ScienceScore;
    public double EnglishScore;
    public Student(string name, double mathScore, double scienceScore, double englishScore)
    {
        Name = name;
        MathScore = mathScore;
        ScienceScore = scienceScore;
        EnglishScore = englishScore;
    }

    public double CalculateAverage()
    {
        return (MathScore + ScienceScore + EnglishScore) / 3;
    }
    public string GetGrade()
    {
        double average = CalculateAverage();

        if (average >= 90)
            return "A";
        else if (average >= 80)
            return "B";
        else if (average >= 70)
            return "C";
        else if (average >= 60)
            return "D";
        else
            return "F";
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nStudent Name: " + Name);
        Console.WriteLine("Math Score: " + MathScore);
        Console.WriteLine("Science Score: " + ScienceScore);
        Console.WriteLine("English Score: " + EnglishScore);
        Console.WriteLine("Average Score: " + CalculateAverage().ToString("0.00")); // Format average to 2 decimal places
        Console.WriteLine("Grade: " + GetGrade());
    }
}

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Calculator!");

            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            double mathScore;
            while (true)
            {
                Console.Write("Enter Math score (0-100): ");
                if (double.TryParse(Console.ReadLine(), out mathScore) && mathScore >= 0 && mathScore <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
            }

            double scienceScore;
            while (true)
            {
                Console.Write("Enter Science score (0-100): ");
                if (double.TryParse(Console.ReadLine(), out scienceScore) && scienceScore >= 0 && scienceScore <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
            }

            double englishScore;
            while (true)
            {
                Console.Write("Enter English score (0-100): ");
                if (double.TryParse(Console.ReadLine(), out englishScore) && englishScore >= 0 && englishScore <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
            }

            Student student = new Student(name, mathScore, scienceScore, englishScore);

            student.DisplayDetails();
        }
    }
}