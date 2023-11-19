public class ListingActivity : Activity
{
    private new List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private new List<string> _responces = new List<string>();
    public ListingActivity (string name, string description) : base(name, description)
    {}

    public void Activity()
    {
        start();
        Random index = new Random();
        int i = index.Next(0,_prompts.Count);
        Console.WriteLine(_prompts[i]);
        countDown();
        startTimer();
        while (getIsTimerRunning())
        {
            RecordResponce();
        }
        
    }

    public void ShowNumberOfResponses()
    {
        Console.WriteLine($"You made {_responces.Count} responses");
    }
    public void RecordResponce()
    {
        string responce = Console.ReadLine();
        _responces.Add(responce);
    }
}