// For each activity, they want to track the the date and the length of the activity in minutes.
// Cycling: speed

// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored directly):
// The distance, The speed (miles per hour), The pace (minutes per mile)

public class Bicycle : Activity{

    private string _type = "Stationary Bicycles";
    private int _distance;

    public Bicycle(string date, int time, int distance) :base(date, time)
    {
        _distance = distance;
    }

    public override string GetType(){
        return _type;
    }

    // Distance (miles) = distance / 1000 * 0.62
    public override double GetDistance(){
        return _distance;
    }
}