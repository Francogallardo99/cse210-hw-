using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running("Run", 30, 5);
        Activity cycling = new Cycling("Cycle", 60, 10);
        Activity swimming = new Swimming("Swim", 45, 20);   

        List<Activity> activities = new List<Activity> { running, cycling, swimming };
        foreach (var Activity in activities)
        {
            Console.WriteLine(Activity.GetSummary());
        }
    }
}