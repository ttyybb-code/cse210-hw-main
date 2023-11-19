public abstract class Shape
{
    private string _Color;

    public string GetColor()
    {
        return _Color;
    }

    public void SetColor(string Color)
    {
        _Color = Color;
    }

    public abstract double GetArea();
}