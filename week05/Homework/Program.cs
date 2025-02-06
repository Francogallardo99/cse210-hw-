using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment ("Jorge" , "Math assignment");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment = new MathAssignment ("Daiana", "Fractions" , 2.5f , "3-5");
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());

        WritingAssignment writingassignment = new WritingAssignment ("Franco" , "writing assignment", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}