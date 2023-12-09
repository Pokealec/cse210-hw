using System;
// Once you have the classes in place, write a program that creates at least one activity of each type. 
// Put each of these activities in the same list. 
// Then iterate through this list and call the GetSummary method on each item and display the results.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracker");
        Running running1 = new Running("23 Jan 2024", 30, 20);
        Bicycle bicycle1 = new Bicycle("28 Feb 2023", 15, 23);
        Swimming swimming1 = new Swimming("3 Mar 2025", 5, 10);

        List<Activity> activities = new List<Activity>{
            running1, bicycle1, swimming1
        };
        
        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}