class Circle : Shape
{
    private double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        double result = 3.14 * (_radius * _radius);
        return result;
    }
}