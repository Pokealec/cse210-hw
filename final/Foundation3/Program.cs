// Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.
// Remember that any data or methods that are common among all types of events should be in the base class.
// Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
// In addition, your program must:
// Use inheritance to avoid duplicating shared attributes and methods.
// Use an address class for the addresses.
// Follow the principles of encapsulation, making sure each member variable is private.

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("15 E South Temple", "Salt Lake City", "Utah", "USA");
        Lecture event1 = new("Mission President's Fireside", "President Fenn is going to hold a Q&A for the Young Elders. Please come if you have any questions!","December 13, 2023","7:00 pm", address1, "President Jerry D. Fenn", 60);
        Console.WriteLine();
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();
        Address address2 = new("221 W Mayflord Lane", "Mayfield", "Utah", "USA");
        Reception event2 = new("Whiffen Marriage Reception", "Elder Whiffen is getting married to his sweetheart Brenna!", "August 26, 2020", "1:00 pm", address2);
        Console.WriteLine();
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event2.GetShortDescription());
        Console.WriteLine();
        Address address3 = new("4984 Gus Lane", "Rio", "Brazil", "South America");
        Gathering event3 = new("Gus' Birthday Party", "Gus Is having a birthday party and we are all invited!", "May 17, 2024", "12:46 pm", address3, "Sunny");
        Console.WriteLine();
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(event3.GetShortDescription());
        Console.WriteLine();        
    }
}