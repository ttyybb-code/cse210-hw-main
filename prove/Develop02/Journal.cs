public class Journal
{
    public void Display()
    {
        string pageContent = File.ReadAllText("page.txt");
        string[] entries = pageContent.Split(new [] { "~" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string entry in entries)
        {
            Console.WriteLine(entry.Trim());
        }
    }
}