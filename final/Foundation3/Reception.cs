// Receptions, which require people to RSVP, or register, beforehand.

public class Reception : Event{

    private string _register = "Please make sure to RSVP before the event!";
    private string _type = "Reception";

    public Reception(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {}

    public override string GetFullDetails(){ // Lists title, description, date, time, and address, plus type of event and information specific to that event type
        return $"{_title}\n{_type}\nOn {_date} at {_time}\nWhere: {_address.ConciseAddress()}\n    {_register}";
    }
    public override string GetShortDescription(){ // Lists the type of event, title, and the date
        return $"{_type} - {_title} on {_date}";
    } 

}