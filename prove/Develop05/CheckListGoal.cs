using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _timesFinished = 0;
    private int _goalNumber = 5;
    public ChecklistGoal(string name, int exp = 200, string progress = "[ ]", string finishedVisual = "[X]") : base(name, exp, progress, finishedVisual)
    {

    }

    public override string GetFinished()
    {
        if(_timesFinished == _goalNumber)
        {
        return GetFinishedVisual();
        }
        else
        {
            return $"{_timesFinished} / {_goalNumber}";
        }
    }

    public void setGoalNumber(int number)
    {
        _goalNumber = number;
    }
    public override int CompleateGoal()
    {
        if(_timesFinished == _goalNumber)
        {
        setFinished();
        return GetExpValue();}
        else
        {
            _timesFinished += 1;
            return GetExpValue() / 10;
        }
    }
}