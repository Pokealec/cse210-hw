// For each activity, they want to track the the date and the length of the activity in minutes.
// Swimming: number of laps

// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored directly):
// The distance, The speed (miles per hour), The pace (minutes per mile)

// the length of a lap in the lap pool is 50 meters.

public class Swimming : Activity{

    private string _type = "Swimming in the lap pool";
    private int _laps;
    
    public Swimming(string date, int time, int laps) :base(date, time)
    {
        _laps = laps;
    }

    public override string GetType(){
        return _type;
    }

    // Distance (miles) = swimming laps * 50 / 1000 * 0.62
    public override double GetDistance(){
        return _laps * 50 * 0.000621371; // got some help from ChatGPT
    }
}