using System;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


class Program{

    static void Main(string[] args){

        // default prompts:
        List<string> prompts = new List<string>();

        prompts.Add("What was the best part of my day?");
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("How did I see the hand of the Lord in my life today");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What was my favorite part of today?");
        prompts.Add("What was good or bad about today?");

        int response;

        // Prompt user with menu:

        Console.WriteLine("Greetings. Welcome to Journal App!\nWhat would you like to do? \n1 = Write new entry \n2 = Load Journal from file \n3 = Display all entries \n4 = Quit program\n");
        response = int.Parse(Console.ReadLine());

        // if user pick new entry
        if (response == 1){
        
        // 1 pick rand prompt

        // 2 display rand prompt
        
        // 3 save entry from user
        
        // 4 create entry object

        // 5 save response object to Journal object
        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToString("yyyy-MM-dd");
        entry.Prompt = ""; // from prompt above
        entry.Response = ""; // pull from user's response

        }

        Journal journal = new Journal();
        journal.JournalName = ""; // ask user for their name
        //journal.Entries = new List<Entry>();
        journal.Entries.Add(entry);

        //save journal to file system
        Public static void SaveToFile(List<Entry> Entries){
            // sets name for new file to be saved
            String filename = "Journal.txt";

            using (StreamWriter outputFile = new StreamWriter(filename)){

                foreach (Entry p in Entries){
                    outputFile.WriteLine(p.EntryDate)
                    outputFile.WriteLine(p.Prompt)
                    outputFile.WriteLine(p.Response)
                }
            }

        }
    }
}

