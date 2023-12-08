// Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

// They would like the ability to generate three different messages:
// 1- Standard details - Lists the title, description, date, time, and address.
// 2- Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
// 3- Short description - Lists the type of event, title, and the date.
using System.Runtime.CompilerServices;

public abstract class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    { // this sets the private variables above
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public String GetStandardDetails(){ // Lists the title, description, date, time, and address
        return $"{_title}\n{_description}\nThis will happen on {_date} at {_time}\nLocation: {_address.ConciseAddress()}";
    }

    public abstract string GetFullDetails(); // Lists all of the above, plus type of event and information specific to that event type
    

    public abstract string GetShortDescription(); // Lists the type of event, title, and the date

}