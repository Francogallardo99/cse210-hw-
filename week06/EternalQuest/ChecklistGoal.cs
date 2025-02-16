public class ChecklistGoal : Goal
{
    public int TotalTimes { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int value, int totalTimes, int bonusPoints)
        : base(name, description, value)
    {
        TotalTimes = totalTimes;
        TimesCompleted = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (TimesCompleted < TotalTimes)
        {
            TimesCompleted++;
            int pointsEarned = Value;

            if (TimesCompleted == TotalTimes)
            {
                pointsEarned += BonusPoints;
                Console.WriteLine($"Congratulations! You've completed the {Name} goal and earned {pointsEarned} points (including bonus).");
            }
            else
            {
                Console.WriteLine($"You have completed an event for the goal: {Name} and earned {pointsEarned} points.");
            }
        }
    }

    public override void DisplayGoal()
    {
        string completionStatus = TimesCompleted == TotalTimes ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name} - {Description} (Completed {TimesCompleted}/{TotalTimes} times, Value: {Value} points, Bonus: {BonusPoints} points)");
    }
}
