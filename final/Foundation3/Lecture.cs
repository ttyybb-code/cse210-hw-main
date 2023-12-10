public class Lecture : Event
{
    private string _Speaker;
    private int _Capacity;

    public Lecture(Address Address, string time, string date, string description, string title, string type, string speaker, int capacity) : base(Address, time, date, description, title, type)
    {
        _Capacity = capacity;
        _Speaker = speaker;
    }

    public override string FullDetails()
    {
        return $"{GetTitle()} {GetDescription()} {GetDate()} {GetTime()} {GetAddress()} {_Speaker}, Capacity: {_Capacity}";
    }
}