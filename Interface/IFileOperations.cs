public interface IFileOperations
{
    /// <summary>
    /// Create a new file
    /// </summary>
    /// <param name="filePath"></param>
    void CreateNewFile(string filePath);
    /// <summary>
    /// Write content to any file.
    /// WARNING: This will override the content within the file.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="content"></param>
    void WriteContent(string filePath, string content);
    /// <summary>
    /// Append content to a file.
    /// WARNING: This might corrupt the target file.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="content"></param>
    void AppendContent(string filePath, string content);
    /// <summary>
    /// Read the content of any file.
    /// </summary>
    /// <param name="filePath"></param>
    void ReadFile(string filePath);

    void ReadBytes(string filePath);
}