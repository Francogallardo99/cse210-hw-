using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breath.")
    {
    }
    public override void Run()
    {
        Start();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(5);
            Console.WriteLine("Breathe out...");
            Pause(5);
        }
    }
}