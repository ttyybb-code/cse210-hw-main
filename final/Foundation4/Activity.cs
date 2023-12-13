public abstract class Activity
{
    private string _Date;
    private int _Time;
    private string _Name;

    public Activity(string date, int time, string name)
    {
        _Date = date;
        _Time = time;
        _Name = name;
    }

    public string GetSummery()
    {
        return $"{_Date} {_Name} ({_Time} min)- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }

    public int GetTime()
    {
        return _Time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();   
}