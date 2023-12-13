using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling("03 Nov 2022", 30, "Cycling", 15);
        Swimming swimming = new Swimming("03 Nov 2022", 10, "Swimming", 5);
        Running running = new Running("03 Nov 2022", 13, "running", 20);
        List<Activity> activities = new List<Activity>{cycling, swimming, running};
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummery());
        }
    }
}