using System.ComponentModel;

class Square : Shape
{
    private double _side;

    public void SetSide(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        double result = _side * _side;
        return result;
    }
}