class Menu : Activity
{
    // display all the options for the user
    // once the user selects an option, display the description of the option
    private List<string> options = new()
    {
        "Breathing Activity",
        "Listing Activity",
        "Reflection Activity"
    };
    private List<string> optionDescs = new()
    {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    };
    private string activityName;

    public void WorkMenu()
    {
        UserSelection();
    }

    private void DisplayOptions()
    {
        for(int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}\n\t{optionDescs[i]}");
        }
    }
    private int PromptForInteger(string promptMessage)
    {
        while (true)
        {
            Console.Write(promptMessage);
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                // User wants to exit.
                return -1;
            }

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("That's not a valid number. Please enter a valid number or press Enter to exit.");
            }
        }
    }
   private void UserSelection()
   {
    DisplayOptions();
    while(true){
        string selectionInput = PromptUser("Please make a selection (Type the number or press Enter to exit): ");
        if (string.IsNullOrWhiteSpace(selectionInput))
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            break;
        }

        if (!int.TryParse(selectionInput, out int selection))
        {
            Console.WriteLine("Invalid selection. Please try again.");
            continue;
        }

        int userDurationTime = PromptForInteger("How long would you like to perform this activity? (in seconds): ");
        if (userDurationTime == -1) break; // User chose to exit when prompted for duration.
        
        SetDuration(userDurationTime);
        switch(selection)
        {
            case 1:
                MessageWithDelay("Please take a moment to prepare for the breathing activity", 5);
                BreathingActivity breathingActivity = new(); // new instance of Breathing activity
                breathingActivity.SetDuration(userDurationTime);
                breathingActivity.Breathing(); // calls breathing function
                activityName = "Breathing";
                break;
            case 2:
                MessageWithDelay("Please take a moment to prepare for the listing activity", 5);
                ListingActivity listingActivity = new(); // new instance of Listing activity
                listingActivity.SetDuration(userDurationTime);
                listingActivity.Listing();
                activityName = "Listing";
                break;
            case 3:
                MessageWithDelay("Please take a moment to prepare for the reflection activity", 5);
                ReflectionActivity reflectionActivity = new(); // new instance of Reflection activity
                reflectionActivity.SetDuration(userDurationTime);
                reflectionActivity.Reflecting();
                activityName = "Reflection";
                break;
            default:
                Console.WriteLine("Thanks!");
                Environment.Exit(0); // Exits the program
                break;
        }
        Console.Clear();
        Console.WriteLine($"Nice job! You spent {durationTime} seconds on the {activityName} activity. Either select another activity or press enter to exit the program.");
    }   
    
   }
}