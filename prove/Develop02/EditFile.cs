class EditFile
{
    private string filepath;

    private void PromptUser()
    {
        Console.Write("Please enter the filepath to your csv file: ");
        filepath = Console.ReadLine();
    }

    public void SaveJournalEntry(List<string> entries, List<string> prompts, List<string> dates)
    {
        PromptUser();
        try
        {
            using (StreamWriter writer = new(filepath))
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    writer.WriteLine(string.Join("~|", prompts[i], entries[i], dates[i]));
                }
            }
            Console.WriteLine("Saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void DisplayJournal()
    {
        PromptUser();
        try
        {
            using (StreamReader reader = new(filepath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(new[] { "~|" }, StringSplitOptions.None);
                    foreach (string value in values)
                    {
                        Console.WriteLine(value);
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}