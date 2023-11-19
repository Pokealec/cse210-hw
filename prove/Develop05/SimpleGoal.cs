public class SimpleGoal : Goal
{
    public SimpleGoal(List<string> names, List<string> descs, List<int> points, List<bool> completions) : base(names, descs, points, completions){

    }
    public override void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine(); 

        Console.Write("How many points is this worth? ");
        int goalPoint = int.Parse(Console.ReadLine());

        goalNames.Add(goalName);
        goalDescs.Add(goalDesc);
        goalPoints.Add(goalPoint);
        goalCompletions.Add(false);
    }
    public override int CompleteGoal(int userPoints)
    {
        while(true){
            // SimpleGoal and EternalGoal complete logic
            List<string> goalNames = GetGoalNames();

            if (goalNames.Count > 0)
            {
                for (int i = 0; i < goalNames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goalNames[i]}");
                }
                
                Console.Write("Select the goal you would like to complete: ");

                int selectedGoalIndex = int.Parse(Console.ReadLine()) - 1;

                if (selectedGoalIndex >= 0 && selectedGoalIndex <= goalNames.Count)
                {
                    Console.WriteLine("Goal completed successfully!");
                    goalCompletions[selectedGoalIndex] = true;
                    return userPoints += goalPoints[selectedGoalIndex];
                }
                else
                {
                    Console.WriteLine("Invalid goal selection. Please choose a valid goal.");
                }
            }
            else
            {
                Console.WriteLine("No goals in the selected category.");
                return userPoints;
            }
        }
    }
}


// Your mother was a hampster, and your father smelt of elder berries!