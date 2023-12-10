public class Cycling : Activity
{
    private int _Speed;
    public Cycling(string date, int time, string name, int speed) : base(date, time, name)
    {
        _Speed = speed;
    }

    public override int GetDistance()
    {
        return _Speed * GetTime() / 60;
    }
    public override int GetSpeed()
    {
        return _Speed;
    }
    public override int GetPace()
    {
        return 60/ _Speed;
    }
}