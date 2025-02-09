using System;

public class ListingActivity : Activity
{
    private readonly string [] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base ("Listining Activity" ,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        Start();
        DateTime startTime = DateTime.Now;
        int itemCount = 0;

        while ((DateTime.Now - startTime).TotalSeconds < Duration) 
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Pause(5);

            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"\n You listed {itemCount} items.");
        End();
    }
}