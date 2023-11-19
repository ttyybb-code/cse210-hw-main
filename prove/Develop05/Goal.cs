public abstract class Goal
{

    private string _name;
    private int _expValue;
    private bool _finished = false;
    private string _progress;
    private string _finishedVisual;

    public Goal(string name, int exp, string progress, string finishedVisual)
    {
        _expValue = exp;
        _progress = progress;
        _finishedVisual = finishedVisual;
        _name = name;
    }
    public string getProgress()
    {
        return _progress;
    }
    public abstract string GetFinished();
    public string GetFinishedVisual()
    {
        return _finishedVisual;
    }
    public string GetName()
    {
        return _name;
    }
    public void setFinished()
    {
        _finished = true;
    }
    public bool getIsFinished()
    {
        return _finished;
    }
    public int GetExpValue()
    {
        return _expValue;
    }
    public virtual int CompleateGoal()
    {
        _finished = true;
        return _expValue;
    }

}