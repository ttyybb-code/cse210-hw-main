using System.Timers;
public class Breathing_activity : Activity
{
    
    public Breathing_activity(string name, string description) : base(name, description)
    {

    }

    public void Activity()
    {
        start();
        startTimer();
        while (getIsTimerRunning())
        {
            Console.Write("Breathe in ...");
            countDown();
            Console.WriteLine("");
            Console.Write("Breathe out...");
            countDown();
            Console.WriteLine("");
        }
    }
}