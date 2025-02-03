public interface IStorage<T>
{
    /// <summary>
    /// Set method
    /// </summary>
    /// <param name="value">generic type value T</param>
    void Set(T value);
    /// <summary>
    /// Get method
    /// </summary>
    /// <returns>T value</returns>
    T Get();
}