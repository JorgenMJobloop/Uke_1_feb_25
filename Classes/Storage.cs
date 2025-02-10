public class Storage<T> : IStorage<T>
{
    private T? data;

    public T Get()
    {
        if (data == null)
        {
            throw new Exception("value cannot be null!");
        }
        return data;
    }

    public void Set(T value)
    {
        data = value;
    }

}