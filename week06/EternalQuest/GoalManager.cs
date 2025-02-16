using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public int Score { get; set; } = 0;

    public void CreateNewGoal()
    {
        Console.WriteLine("Choose the type of goal (1 - Simple, 2 - Eternal, 3 - Checklist): ");
        int goalType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the point value for the goal: ");
        int value = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (goalType == 1) 
        {
            goal = new SimpleGoal(name, description, value);
        }
        else if (goalType == 2)
        {
            goal = new EternalGoal(name, description, value);
        }
        else if (goalType == 3)
        {
            Console.WriteLine("Enter the total number of times to complete this goal: ");
            int totalTimes = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points for completing the goal: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, value, totalTimes, bonusPoints);
        }

        Goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoals()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        foreach (var goal in Goals)
        {
            goal.DisplayGoal();
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (var goal in Goals)
            {
                sw.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Value}");
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        Goals.Clear();

        foreach (var line in File.ReadLines("goals.txt"))
        {
            var parts = line.Split('|');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int value = int.Parse(parts[3]);

            Goal goal = null;

            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal(name, description, value);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(name, description, value);
            }
            else if (goalType == "ChecklistGoal")
            {
                goal = new ChecklistGoal(name, description, value, 0, 0);
            }

            Goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal number to record an event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
