using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1- Brething Activity");
            Console.WriteLine("2- Refelction Activity");
            Console.WriteLine("3- Listing Activity");
            Console.WriteLine("4- Exit");
            Console.Write("\nChoose an activity: \n");
            string choise = Console.ReadLine();

            Activity activity = null;

            switch(choise)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Have a great day :)");
                    return;
                default:
                    Console.WriteLine("Invalid option. Choose a numbre o the list :)");
                    continue;
            }
            activity.Run();
        }
    }
}