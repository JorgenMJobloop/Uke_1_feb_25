public class GenericStorage<T>
{
    private T? value;

    public void SetValue(T _value)
    {
        value = _value;
    }

    public T GetValue()
    {
        // Simple null check
        if (value == null)
        {
            throw new Exception("value cannot be null!");
        }
        else
        {
            return value;
        }
    }
}