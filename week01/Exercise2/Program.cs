using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What was your grade percentage? ");
        string gradePercentage= Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine ($"You have an {letter} in your exam");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! You pass the exam");
        }
        else
        {
            Console.WriteLine("You can try the next time");
        }
    }
}