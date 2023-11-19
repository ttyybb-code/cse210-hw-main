using System.Security.Cryptography.X509Certificates;
using System.Timers;
public class Activity
{
    private string _Description;

    private string _Name;

    private bool _IsTimerRunning = false;
    protected System.Timers.Timer _timer;
    
    private List<string> _animation = new List<string>{"/","-","|","\\"};

    private int _time;
    public Activity(string name, string description)
    {

        _Name = name;
        _Description = description;
    }


    public void SetTime()
    {
        Console.WriteLine("How long, in seconds, would you for your session");
        _time = int.Parse(Console.ReadLine()) * 1000;
    }

    public virtual void PrintEndingMessage(object sender, ElapsedEventArgs e)
    {
        _IsTimerRunning = false;
        Console.Clear();
        Console.WriteLine($"You have finished {_time / 1000} seconds of {_Name}");
        for (int i = 0; i != 3; i++)
        {
            spin();
        }

    }
    public void spin()
    {
        for (int l = 0; l !=1; l ++)
        {
            for (int i = 0; i < _animation.Count; i++)
        {
            Console.Write(_animation[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        }
    }

    public void start()
    {
        Console.WriteLine($"Welcome to {_Name}");
        Console.WriteLine("");
        Console.WriteLine(_Description);
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        for (int i = 0; i != 3; i++)
        {
            spin();
        }
        _timer = new System.Timers.Timer(_time);
        _timer.AutoReset = false;
        _timer.Elapsed += PrintEndingMessage;
    }

    public void startTimer()
    {
        _timer.Start();
        _IsTimerRunning = true;
    }

    public bool getIsTimerRunning()
    {
        return _IsTimerRunning;
    }
    public void pauseTimer()
    {
        _timer.Stop();
    }
    public void countDown()
    {
        for (int i = 4; i != 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}