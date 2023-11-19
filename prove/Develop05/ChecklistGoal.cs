public class ChecklistGoal : Goal
{
    List<int> timesToComplete = new List<int>();
    List<int> bigBonus = new List<int>();


    public ChecklistGoal(List<int> times, List<string> names, List<string> descs, List<int> points, List<bool> completions) : base(names, descs, points, completions){
        timesToComplete = times;
    }

    public List<int> GetTimesToComplete()
    {
        return timesToComplete;
    }

    public List<int> GetBigBonus()
    {
        return bigBonus;
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine();

        Console.Write("How many times do you want to complete this goal before it is checked off? ");
        int timesCompleted = int.Parse(Console.ReadLine());

        Console.Write("How many points is this worth each time it is completed? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many points extra should the final completion give? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        goalNames.Add(goalName);
        goalDescs.Add(goalDesc);
        goalPoints.Add(points);
        goalCompletions.Add(false);
        timesToComplete.Add(timesCompleted);
        bigBonus.Add(bonusPoints);
    }

    public override int CompleteGoal(int userPoints)
    {
        List<string> goalNames = GetGoalNames();

        if (goalNames.Count == 0)
        {
            Console.WriteLine("No goals in the selected category.");
            return userPoints;
        }

        for (int i = 0; i < goalNames.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalNames[i]} [Can complete {timesToComplete[i]} more times]");
        }

        Console.Write("Select the goal you would like to complete: ");
        int selectedGoalIndex = int.Parse(Console.ReadLine()) - 1;

        if (selectedGoalIndex >= 0 && selectedGoalIndex < goalNames.Count && timesToComplete[selectedGoalIndex] > 0)
        {
            Console.WriteLine("Goal completed successfully!");

            timesToComplete[selectedGoalIndex]--;
            userPoints += goalPoints[selectedGoalIndex];

            if (timesToComplete[selectedGoalIndex] == 0)
            {
                // This is the last completion, add big bonus
                userPoints += bigBonus[selectedGoalIndex];
                goalCompletions[selectedGoalIndex] = true;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection or you have already completed this goal the maximum number of times.");
        }

        return userPoints;
    }
}
