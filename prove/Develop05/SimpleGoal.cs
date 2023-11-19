public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int exp = 1000, string progress = "[ ]", string finishedVisual = "[X]") : base(name,exp, progress, finishedVisual)
    {

    }

    public override string GetFinished()
    {
        if (getIsFinished())
        {return GetFinishedVisual();}
        else
        return getProgress();
    }
}