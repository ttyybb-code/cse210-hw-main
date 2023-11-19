public class ReflectionActivity : Activity
{
    private new List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private new List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void Activity()
    {
        start();
        Random index = new Random();
        int i = index.Next(0,_prompts.Count);
        Console.WriteLine(_prompts[i]);
        Thread.Sleep(5000);
        startTimer();
        while (getIsTimerRunning())
        {
            askQuestion();
            Thread.Sleep(5000);
        }
    }

    public void askQuestion()
    {
        Random index = new Random();
        int i = index.Next(0,_questions.Count);
        Console.WriteLine(_questions[i]);
    }
}