public class Cycling : Activity
{
    private double _Speed;
    private double _Pace;
    public Cycling(string date, int time, string name, int speed) : base(date, time, name)
    {
        _Speed = speed;
    }

    public override double GetDistance()
    {
        return _Speed * GetTime() / 60.0;
    }
    public override double GetSpeed()
    {
        return _Speed;
    }
    public override double GetPace()
    {
        _Pace = 60.0/ _Speed;
        return _Pace;
    }
}