public class SimpleGoal : Goal
{
    public bool IsCompleted { get; set; }

    public SimpleGoal(string name, string description, int value)
        : base(name, description, value)
    {
        IsCompleted = false;
    }
    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"You have completed the goal: {Name} and earned {Value} points!");
        }
    }

    public override void DisplayGoal()
    {
        string completionStatus = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name} - {Description} (Value: {Value} points)");
    }
}
