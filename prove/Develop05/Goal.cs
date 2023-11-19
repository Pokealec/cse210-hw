public abstract class Goal
{
    // This is where all goal information is saved first
    protected List<string> goalNames = new(); 
    protected List<string> goalDescs = new();
    protected List<int> goalPoints = new();
    protected List<bool> goalCompletions = new();

    public Goal(List<string> names, List<string> descs, List<int> points, List<bool> completions){
        goalNames = names;
        goalDescs = descs;
        goalPoints = points;
        goalCompletions = completions;
    }

    public List<string> GetGoalNames(){
        return goalNames;
    }
    public List<string> GetGoalDescs(){
        return goalDescs;
    }
    public List<bool> GetGoalCompletions(){
        return goalCompletions;
    }
    public List<int> GetGoalPoints(){
        return goalPoints;
    }
    public abstract void CreateGoal();

    public abstract int CompleteGoal(int userPoints);

    public List<int> AppendScores(List<int> pointList, int points){
        return pointList;
    }

}




// Your mama's so fat, she sat on an iPod and it made the iPad!