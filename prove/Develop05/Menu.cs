using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Menu
{
    int userPoints = 0;
    List<Goal> goalClasses = new()
    {
        new SimpleGoal(new List<string>(), new List<string>(), new List<int>(), new List<bool>()),
        new EternalGoal(new List<string>(), new List<string>(), new List<int>(), new List<bool>()),
        new ChecklistGoal(new List<int>(), new List<string>(), new List<string>(), new List<int>(), new List<bool>()),
    };

    List<string> menuOptions = new()
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };

    List<string> goalTypes = new()
    {
        "Simple",
        "Eternal",
        "Checklist"
    };

    public void instantiateMenu()
    {
        while (true)
        {
            Console.WriteLine($"You have {userPoints} points\n");

            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {menuOptions[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    // Create New Goal
                    CreateNewGoal();
                    break;

                case 2:
                    // List Goals
                    foreach (Goal goal in goalClasses)
                    {
                        Console.WriteLine($"{goal}: ");
                        PrintChecklist(goal);
                    }
                    break;

                case 3:
                    // Save Goals
                    SaveGoals();
                    break;

                case 4:
                    // Load Goals
                    LoadGoals();
                    break;

                case 5:
                    // Record Event (complete goal)
                    CompleteNewGoal();
                    break;

                case 6:
                    // quit
                    Console.WriteLine("Have a great day!");
                    return;
            }
        }
    }

    void CreateNewGoal()
    {
        PrintGoals(goalTypes);
        Console.Write("Which type of goal would you like to create? ");

        int goalChoice = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case 1:
                // Simple Goal
                goalClasses[0].CreateGoal();
                Console.WriteLine("Creation Success!");
                break;

            case 2:
                // Eternal Goal
                goalClasses[1].CreateGoal();
                Console.WriteLine("Creation Success!");
                break;

            case 3:
                // Checklist Goal
                goalClasses[2].CreateGoal();
                Console.WriteLine("Creation Success!");
                break;
        }
    }

    void CompleteNewGoal()
    {
        PrintGoals(goalTypes);
        Console.Write("Select a goal category to complete a goal from: ");
        int categoryIndex = int.Parse(Console.ReadLine());

        switch (categoryIndex)
        {
            case 1: // Simple Goal
                userPoints = goalClasses[0].CompleteGoal(userPoints);
                break;

            case 2: // Eternal Goal
                userPoints = goalClasses[1].CompleteGoal(userPoints);
                break;

            case 3: // Checklist Goal
                userPoints = goalClasses[2].CompleteGoal(userPoints);
                break;
        }
    }

    void PrintChecklist(Goal goal)
    {
        List<string> goalNames = goal.GetGoalNames();
        List<string> goalDescs = goal.GetGoalDescs();
        List<int> goalPoints = goal.GetGoalPoints();
        List<bool> goalCompletions = goal.GetGoalCompletions();

        int goalLength = goalNames.Count;

        for (int n = 0; n < goalLength; n++)
        {
            if (goalCompletions[n])
            {
                Console.WriteLine($"\t{n + 1}. [X] {goalNames[n]} - {goalDescs[n]} - {goalPoints[n]} points");
            }
            else
            {
                Console.WriteLine($"\t{n + 1}. [ ] {goalNames[n]} - {goalDescs[n]} - {goalPoints[n]} points");
            }
        }
    }

    void PrintGoals(List<string> goals)
    {
        Console.WriteLine("The types of Goals are: ");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"\t{i + 1}. {goals[i]} Goal");
        }
    }

    void SaveGoals()
    {
        List<object> goalsInfo = new List<object>();

        foreach (var goalCategory in goalClasses)
        {
            var goalInfo = new
            {
                category = goalCategory.GetType().Name,
                names = goalCategory.GetGoalNames(),
                descs = goalCategory.GetGoalDescs(),
                points = goalCategory.GetGoalPoints(),
                completions = goalCategory.GetGoalCompletions()
            };

            // Include timesToComplete for ChecklistGoal
            if (goalCategory is ChecklistGoal checklistGoal)
            {
                var checklistGoalInfo = new
                {
                    category = goalCategory.GetType().Name,
                    names = goalCategory.GetGoalNames(),
                    descs = goalCategory.GetGoalDescs(),
                    points = goalCategory.GetGoalPoints(),
                    completions = goalCategory.GetGoalCompletions(),
                    timesToComplete = checklistGoal.GetTimesToComplete()
                };
                goalsInfo.Add(checklistGoalInfo);
            }
            else
            {
                goalsInfo.Add(goalInfo);
            }
        }

        var saveData = new
        {
            userPoints,
            goals = goalsInfo
        };

        string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });

        string filePath = "save.json";
        File.WriteAllText(filePath, json);

        Console.WriteLine("Goal information, user points, and times to complete saved to save.json");
    }
    void LoadGoals()
    {
        string json = File.ReadAllText("save.json");

        // Deserialize the JSON data into a dynamic structure
        JsonDocument doc = JsonDocument.Parse(json);
        JsonElement root = doc.RootElement;

        Console.WriteLine(root);
        userPoints = root.GetProperty("userPoints").GetInt32();

        foreach (JsonElement goalCategory in root.GetProperty("goals").EnumerateArray())
        {
            Console.WriteLine("Goal Category:");
            Console.WriteLine($"Category: {goalCategory.GetProperty("category").GetString()}");

            switch (goalCategory.GetProperty("category").GetString())
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(
                        goalCategory.GetProperty("names").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("descs").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("points").EnumerateArray().Select(x => x.GetInt32()).ToList(),
                        goalCategory.GetProperty("completions").EnumerateArray().Select(x => x.GetBoolean()).ToList()
                    );
                    goalClasses[0] = simpleGoal;
                    break;

                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(
                        goalCategory.GetProperty("names").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("descs").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("points").EnumerateArray().Select(x => x.GetInt32()).ToList(),
                        goalCategory.GetProperty("completions").EnumerateArray().Select(x => x.GetBoolean()).ToList()
                    );
                    goalClasses[1] = eternalGoal;
                    break;

                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(
                        goalCategory.GetProperty("timesToComplete").EnumerateArray().Select(x => x.GetInt32()).ToList(),
                        goalCategory.GetProperty("names").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("descs").EnumerateArray().Select(x => x.GetString()).ToList(),
                        goalCategory.GetProperty("points").EnumerateArray().Select(x => x.GetInt32()).ToList(),
                        goalCategory.GetProperty("completions").EnumerateArray().Select(x => x.GetBoolean()).ToList()
                    );
                    goalClasses[2] = checklistGoal;
                    break;

                default:
                    Console.WriteLine($"Unknown category: {goalCategory.GetProperty("category").GetString()}");
                    break;
            }
        }
        
        
        
    }
}