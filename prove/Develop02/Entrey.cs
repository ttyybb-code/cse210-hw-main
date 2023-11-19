public class Entry
{
    public static void WriteToFile(string text, string prompt)
    {
        using (StreamWriter writer = new StreamWriter("page.txt", true))
        {
            writer.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
            writer.WriteLine($"{prompt}: {text}");
            writer.WriteLine("~");
        }

    }

    public void Main()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        string text = Console.ReadLine();

        WriteToFile(text, prompt);
    }
}