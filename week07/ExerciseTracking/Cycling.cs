public class Cycling : Activity
{
    public double DistanceKm;
    public Cycling(string name , double durationMinutes, double distanceKm) : base(name, durationMinutes)
    {
        DistanceKm = distanceKm;
    }
    public override double GetDistance()
    {
        return DistanceKm;
    }
    public override double GetSpeed()
    {
        return (DistanceKm / DurationMinutes) * 60;
    }
    public override double GetPace() => DurationMinutes / GetDistance();
}