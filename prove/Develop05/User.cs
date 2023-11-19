using System.Runtime.CompilerServices;

public class User
{
    private int _exp;
    private int _level;
    private int _expThreshold;
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ViewExp()
    {
        Console.WriteLine($"exp: {_exp}");
    }

    public void ViewLevel()
    {
        Console.WriteLine($"level: {_level}");
    }

    public void LevelUp()
    {
        if (_exp >= _expThreshold)
        {
            _level += 1;
            _exp = 0;
            _expThreshold += 1000;
        }
    }


    public void GainExp(string name)
    {
        for (int i=0; i < goals.Count(); i++)
        {    
        if (goals[i].GetName() == name)    
        {       
        _exp += goals[i].CompleateGoal();
        LevelUp();}
        }
    }

    public void ViewGoals()
    {
        foreach (Goal goal in goals)
        {

            Console.WriteLine($"{goal.GetName()}: {goal.GetFinished()} ");

        }
    }

    public void MakeSimpleGoal()
    {
        Console.Write("Enter the simple goals name: ");
        string Name = Console.ReadLine();
        WriteToFile("SimpleGoals.txt", Name);
    }

public void MakeEternalGoal()
{
        Console.Write("Enter the eternal goals name: ");
        string Name = Console.ReadLine();
        WriteToFile("EternalGoals.txt", Name);
}

public void MakeChecklistGoal()
{
        Console.Write("Enter the checklist goals name: ");
        string Name = Console.ReadLine();
        WriteToFile("ChecklistGoals.txt", Name);
}
    public void WriteToFile(string filePath, string Name)
    {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"{Name};");
            }
    }


}