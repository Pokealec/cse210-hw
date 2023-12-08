// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

public class Gathering : Event{
    private string _forecast;
    private string _type = "Outdoor Gathering";

    public Gathering(string title, string description, string date, string time, Address address, string forecast) 
        : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public override string GetFullDetails(){ // Lists title, description, date, time, and address, plus type of event and information specific to that event type
        return $"{_title}\n{_type}\nOn {_date} at {_time}\nWhere: {_address.ConciseAddress()}\n   Forecast will be {_forecast}!";
    }
    public override string GetShortDescription(){ // Lists the type of event, title, and the date
        return $"{_type} - {_title} on {_date}";
    } 


    
}