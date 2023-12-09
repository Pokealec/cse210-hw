// For each activity, they want to track the the date and the length of the activity in minutes.
// Running: distance

// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored directly):
// The distance, The speed (miles per hour), The pace (minutes per mile)
// A summary in the form of:
// 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
// 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km

// You may choose if your program uses miles or kilometers (you do not need to handle both). In either case the length of a lap in the lap pool is 50 meters.

public class Running : Activity{

    private string _type = "Running";
    private int _distance;

    public Running(string date, int time, int distance) :base(date, time)
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