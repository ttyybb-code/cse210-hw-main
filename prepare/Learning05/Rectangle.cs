public class Rectangle : Shape
{
    private double _length;
    private double _Width;

    public Rectangle(double length, double Width)
    {
        _length = length;
        _Width = Width;
    }
    public override double GetArea()
    {
        return _length * _Width;
    }
}
