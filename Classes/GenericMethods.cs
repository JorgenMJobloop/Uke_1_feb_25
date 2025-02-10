using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
public class GenericMethods
{

    /// <summary>
    /// Add two numbers together
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// 
    public T Add<T>(T a, T b) where T : INumber<T>
    {
        return a + b;
    }
    /// <summary>
    /// Populate an array
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public T[] AddRange<T>(T[] elements)
    {
        return elements;
    }

    public void PrintValues<T>(T[] elements)
    {
        foreach (T elems in elements)
        {
            Console.WriteLine(elems);
        }
    }

    public void Concat(string valueOne, string valueTwo)
    {
        Console.WriteLine(valueOne + " " + valueTwo);
    }
}