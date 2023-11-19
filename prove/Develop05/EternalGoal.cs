using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{


    public EternalGoal(string name, int exp = 500, string progress = "", string finishedVisual = "") : base(name, exp, progress, finishedVisual)
    {
    }

    public override string GetFinished()
    {
        return "";
    }
}