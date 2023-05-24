using System;

class Square : Shapes
{
    private double _side = 0;
    public Square (string color, float side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}