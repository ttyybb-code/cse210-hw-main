using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}