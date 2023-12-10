public class Reception : Event
{
    private string _Email;

    public Reception(Address Address, string time, string date, string description, string title, string type, string email) : base(Address, time, date, description, title, type)
    {
        _Email = email;
        
    }
    public override string FullDetails()
    {
        return $"{GetTitle()} {GetDescription()} {GetDate()} {GetTime()} {GetAddress()} RSVP: {_Email}";
    }
}