public class Assignment
{
    private string _studentName;
    private string _topic;


    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string getSummery()
    {
        return $"{_studentName}: {_topic}";
    }

    public string getName()
    {
        return _studentName;
    }
}