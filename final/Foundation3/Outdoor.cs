public class Outdoor : Event
{
    private string _Weather;

    public Outdoor(Address Address, string time, string date, string description, string title, string type, string weather) : base(Address, time, date, description, title, type)
    {
        _Weather = weather;
        
    }
    public override string FullDetails()
    {
        return $"{GetTitle()} {GetDescription()} {GetDate()} {GetTime()} {GetAddress()} RSVP: {_Weather}";
    }
}