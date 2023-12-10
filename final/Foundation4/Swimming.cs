public class Swimming : Activity
{
    private int _Laps;

    public Swimming(string date, int time, string name, int laps) : base(date, time, name)
    {
        _Laps = laps;
    }
    public override int GetDistance()
    {
        return _Laps * 50 / 1000;
    }
    public override int GetSpeed()
    {
        return GetDistance()/ GetTime() * 60;
    }
    public override int GetPace()
    {
        return GetTime() / GetDistance();
    }
}