public class HelperClass
{
    // Generic method that swaps generic types based on references
    public void Swap<T>(ref T a, ref T b)
    {
        T tempValue = a;
        a = b;
        b = tempValue;
    }
}