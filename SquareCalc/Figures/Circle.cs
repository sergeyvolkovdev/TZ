namespace ClassLibrary2.Figures;

public class Circle : Figure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if(radius < 0)
            throw new ArgumentOutOfRangeException("Radius cannot be negative");

        Radius = radius;
    }
    
    protected sealed override double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}