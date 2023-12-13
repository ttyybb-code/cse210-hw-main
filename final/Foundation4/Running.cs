using System.Diagnostics;

public class Running : Activity
{
    private double _Distance;

    public Running(string date, int time, string name, int distance) : base(date, time, name)
    {
        _Distance = distance;
    }

    public override double GetDistance()
    {
        return _Distance;
    }
    public override double  GetSpeed()
    {

        return _Distance/ GetTime() * 60;
    }
    public override double GetPace()
    {
        return GetTime() / _Distance;
    }
}