using System;
using System.Threading;

public abstract class Activity
{
    public string Name;
    public string Description;
    public int Duration;

    public Activity (string name ,  string description)
    {
        Name = name;
        Duration = 0;
        Description = description;
    }
    
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {Name}");
        Console.WriteLine(Description);
        Console.WriteLine("\n Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Get ready...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("Great Job!");
        Pause(3);
        Console.WriteLine($"You completed {Name} in {Duration} seconds!");
        Pause(3);
    }
    protected void Pause(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|", "/", "─", "\\"
        };
        for (int i = 0; i < seconds; i++)
        {
            foreach (var animation in animationStrings)
            {
                Console.Write($"\r{animation}");
                Thread.Sleep(250);
            }
        }
        Console.WriteLine();
    }
    public abstract void Run();
}