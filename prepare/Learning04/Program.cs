using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Keith Crawford", "Exam");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment massignment= new MathAssignment("Keith Crawford", "Lesson 11 problems", "Section 8.1", "Problems 10-15");
        Console.WriteLine(massignment.GetHomeworkList());
        WritingAssignment wassignment = new WritingAssignment("Keith Crawford", "New Age Writing", "Modern Politics in 2024");
        Console.WriteLine(wassignment.GetWritingInformation());
    }
}