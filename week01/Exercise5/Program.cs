using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square= SquareNumber(userNumber);
        DisplayResult(userName , square);
        
        static void DisplayMessage ()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName ()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;            
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult (string name , int square)
        {
            Console.WriteLine ($"{name} , the square of your favorite number is {square}");

        }
    }
}