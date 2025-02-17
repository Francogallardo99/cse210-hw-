using System;

public abstract class Activity
{
    public string Name;
    public double DurationMinutes;
    public Activity(string name , double durationMinutes)
    {
        Name = name;
        DurationMinutes = durationMinutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace ();
    public virtual string GetSummary()
    {
        return $"Activity: {Name}, Duration: {DurationMinutes} minutes, Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} km/h, Pace: {GetPace():0.00} min/km";
    }
}