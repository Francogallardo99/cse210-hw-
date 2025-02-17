public class Swimming : Activity
{
    public int Laps;
    public Swimming(string name , double durationMinutes , int laps) : base(name, durationMinutes)
    {
        Laps = laps;
    }   
    public override double GetDistance()
    {
        return Laps * 50  / 1000.0;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }
    public override double GetPace() => DurationMinutes / GetDistance();
}