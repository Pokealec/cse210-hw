// For each activity, they want to track the the date and the length of the activity in minutes. 
// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored directly):
// The distance, The speed (miles per hour), The pace (minutes per mile)

public abstract class Activity
{
    protected string _date;
    protected int _time;

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public string GetDate()
    {
        return _date;
    }

    public new abstract string GetType();
    public abstract double GetDistance();
    public double GetSpeed()
    {
        // Ensure _time is greater than 0 to avoid division by zero
        if (_time > 0)
        {
            // Speed (mph or kph) = (distance / minutes) * 60 OR Speed = 60 / pace
            return GetDistance() / _time * 60;
        }
        else
        {
            return 0;
        }
    }

    public double GetPace()
    {
        // Ensure speed is greater than 0 to avoid division by zero
        double speed = GetSpeed();
        if (speed > 0)
        {
            // Pace = 60 / speed
            return 60 / speed;
        }
        else
        {
            return 0;
        }
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_time} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}