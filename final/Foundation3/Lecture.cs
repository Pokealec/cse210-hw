// Lectures, which have a speaker and have a limited capacity.

public class Lecture : Event{
    private string _speaker;
    private string _capacity;
    private string _type = "Lecture";

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity.ToString();
    }

    public override string GetFullDetails(){ // Lists title, description, date, time, and address, plus type of event and information specific to that event type
        return $"{_title}\n{_type}\n{_speaker} will be speaking! \nOn {_date} at {_time}\nWhere: {_address.ConciseAddress()}\nCapacity: {_capacity}";
    }
    public override string GetShortDescription(){ // Lists the type of event, title, and the date
        return $"{_type} - {_title} on {_date}";
    } 


    
}