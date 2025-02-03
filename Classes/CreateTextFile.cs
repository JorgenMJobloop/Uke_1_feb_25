public class CreateTextFile
{
    public void CreateNewTextFile(string filePath)
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
}