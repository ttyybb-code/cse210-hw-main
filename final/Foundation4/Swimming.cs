public class Swimming : Activity
{
    private int _Laps;
    private double _Distance;
    public Swimming(string date, int time, string name, int laps = 1) : base(date, time, name)
    {
        _Laps = laps;
    }
    public override double GetDistance()
    {
        _Distance = _Laps * 0.5;
        return _Distance;
    }
    public override double  GetSpeed()
    {
        return _Distance/ GetTime() * 60;
    }
    public override double  GetPace()
    {
        return GetTime() / GetDistance();
    }
}