public class CreateTextFile : IFileOperations
{
    public void CreateNewFile(string filePath)
    {
        if (!File.Exists("my_text.txt"))
        {
            File.Create("my_text.txt");
        }
    }

    public void WriteContent(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }

    public void AppendContent(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
    }
    public void ReadFile(string filePath)
    {
        var fileToRead = File.ReadAllText(filePath);
        Console.WriteLine(fileToRead);
    }

    public void ReadBytes(string filePath)
    {
        var readBytes = File.ReadAllBytes(filePath);
        foreach (byte bytes in readBytes)
        {
            Console.WriteLine(bytes);
        }
    }
}