public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value)
        : base(name, description, value)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"You have completed an event for the goal: {Name} and earned {Value} points!");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} - {Description} (Value: {Value} points, Eternal Goal)");
    }
}
