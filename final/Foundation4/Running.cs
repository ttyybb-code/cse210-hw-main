using System.Diagnostics;

public class Running : Activity
{
    private int _Distance;

    public Running(string date, int time, string name, int distance) : base(date, time, name)
    {
        _Distance = distance;
    }

    public override int GetDistance()
    {
        return _Distance;
    }
    public override int GetSpeed()
    {
        return _Distance/ GetTime() * 60;
    }
    public override int GetPace()
    {
        return GetTime() / _Distance;
    }
}