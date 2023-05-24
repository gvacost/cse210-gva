using System;

class Rectangle : Shapes
{
    private double _side_ = 0;
    private double _lenght = 0;

    public Rectangle (string color, double side_, double lenght) : base (color)
    {
        _side_ = side_;
        _lenght = lenght;
    }


    public override double GetArea()
    {
        return _side_*_lenght;
    }

}