using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top_, int bottom)
    {
        _top = top_;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text =($"{_top}/{_bottom}");
        return text;

    }

    public double GetDecimalValue()
    {
        double dec_value = (double)_top/(double)_bottom;
        return dec_value; 
    }
}