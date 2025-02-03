public class Calculator
{
    /// <summary>
    /// Field value for a
    /// </summary>
    public double a;
    /// <summary>
    /// Field value for b
    /// </summary>
    public double b;
    /// <summary>
    /// Add together the value of x + y
    /// </summary>
    /// <param name="x">value of x</param>
    /// <param name="y">value of y</param>
    /// <returns>x + y</returns>
    public double Add(double x, double y)
    {
        return x + y;
    }
    public double AddStrict()
    {
        return a + b;
    }
}