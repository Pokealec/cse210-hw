class Activity
{
    private DateTime activityEnd;
    protected double durationTime; 

    public void SetActivityEnd(int durationInSeconds)
    {
        durationTime = durationInSeconds;
        activityEnd = DateTime.Now.AddSeconds(durationInSeconds + 5);
    }
    public DateTime GetActivityEnd()
    {
        return activityEnd;
    }

    public void SetDuration(int userDuration)
    {
        durationTime = userDuration;
        SetActivityEnd(userDuration);
    }

    static public string PromptUser(string promptMessage)
    {
        Console.Write(promptMessage);
        return Console.ReadLine();
    }
    public void Delay(int time)
    {
        Thread.Sleep(time * 1000);
    }
    public void MessageWithDelay(string message, int delayTime)
    {
        Console.Clear();
        Console.WriteLine(message);
        LoadingBar(delayTime);
        Console.Clear();
    }
    public void LoadingBar(int loadDuration)
    {
        int length = 20;
        string loadingBar;

        for (int i = 0; i <= length; i++)
        {
            loadingBar = "[" + new string('█', i) + new string('-', length - i) + "]";
            Console.Write("\r" + loadingBar); // \r moves the cursor to the start of the line
            Thread.Sleep(loadDuration * 1000 / length);
        }
    }
    public void Spinner(int durationInSeconds)
{
    char[] spinnerChars = { '/', '—', '\\', '|' };
    int spinnerIndex = 0;
    DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

    while (DateTime.Now < endTime)
    {
        // Display the next spinner character
        Console.Write("\r{0}", spinnerChars[spinnerIndex]);

        // Update the spinner index to the next character
        spinnerIndex++;
        if (spinnerIndex >= spinnerChars.Length)
        {
            spinnerIndex = 0;
        }

        // Slow down the spinner so it's visible
        Thread.Sleep(500);
    }

    // Clear the spinner from the current line after the duration has passed
    Console.Write("\r ");
}
    public string RandomItem(List<string> inputArray)
    {
        Random random = new();
        int randomNum = random.Next(0, inputArray.Count);
        return inputArray[randomNum];
    }
}