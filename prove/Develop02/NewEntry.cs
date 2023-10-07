class NewEntry
{
    public List<string> Entries { get; } = new();
    public List<string> Prompts { get; } = new();
    public List<string> Dates { get; } = new();

    private static string RandomPrompt()
    {
        string filePath = "prompts.csv";
        string[] lines = File.ReadAllLines(filePath);
        Random random = new();
        int randomLineNumber = random.Next(0, lines.Length);
        return lines[randomLineNumber];
    }

    public void GetUserInput()
    {
        string selectedPrompt = RandomPrompt();
        Console.WriteLine($"Your Prompt: {selectedPrompt}");
        Entries.Add(Console.ReadLine());
        Dates.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        Prompts.Add(selectedPrompt);
    }
}