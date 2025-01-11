using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next (1, 101);
        Console.WriteLine("You need to guess the number I'm thinking of.");
        int guess = 0;

        while ( guess != magicNumber)
        {
            
            Console.Write("Give me a number: ");        
            string numberTry = Console.ReadLine();
            guess = int.Parse(numberTry);        
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You have guessed the magic number");
            
            }
        }
    }
}