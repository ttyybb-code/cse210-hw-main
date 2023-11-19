using System.Runtime.CompilerServices;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int getTop()
    {
        return _topNumber;
    }

    public int getBottom()
    {
        return _bottomNumber;
    }

    public void setTop(int top)
    {
        _topNumber = top;
    }

    public void setBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string top = _topNumber.ToString();
        string bottom = _bottomNumber.ToString();
        
        return $"{top}/{bottom}";
    }

    public string GetDecimalValue()
    {
        float value = _topNumber / _bottomNumber;
        return $"{value}";
    }
};

