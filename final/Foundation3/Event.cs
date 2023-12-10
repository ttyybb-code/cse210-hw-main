

public abstract class Event
{
    private Address _Address;
    private string _Time;
    private string _Date;
    private string _Description;
    private string _Title;
    private string _Type;

    public Event(Address Address, string time, string date, string description, string title, string type)
    {
        _Address = Address;
        _Time = time;
        _Date = date;
        _Description = description;
        _Title = title;
        _Type = type;
    }

    public string StandardDetails()
    {
        return $"{_Title} {_Description} {_Date} {_Time} {_Address}";
    }
    public string GetTitle()
    {
        return _Title;
    }

    public Address GetAddress()
    {
        return _Address;
    }
    public string GetTime()
    {
        return _Time;
    }
    public string GetDate()
    {
        return _Date;
    }
    public string GetDescription()
    {
        return _Description;
    }
    public abstract string FullDetails();

    public string ShortDescription()
    {
        return $"{_Type} {_Title} {_Date}";
    }
}