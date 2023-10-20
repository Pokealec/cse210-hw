using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // This is where it makes the dictionary
        ScriptText printScript = new();
        printScript.makeDict();

        // This selects a random entry from the dictionary
        ScriptSel selection = new();
        string returnvalue =  selection.RandScript(printScript.GetScript()); // returns entry (Script ref and script)
        
        // Console.WriteLine(returnvalue);

        RemoveWord remword = new();
        remword.convertToList(returnvalue); // converts scripture string into a list of words
        remword.printlist(); //prints list of words from selected scripture

        Console.WriteLine("\nPress Enter to start removing words.");

        string userInput = Console.ReadLine();

        // create loop here to clear screen and remove words from the wordlist.
        while (remword.GetWordsRemoved() < remword.getTextList().Count){
            Console.Clear();
            if(userInput == "quit"){
                break;
            }
            else
            {
                remword.RemoveDaWords();
                //remword.printlist();
                Console.WriteLine("\nType 'quit' and press Enter when done. Just press Enter to remove more words.\n");
                userInput = Console.ReadLine();
            }
                        
        }

        Console.Clear();
        Console.WriteLine("\nThank you for reading the scriptures! \nGood luck with your studies! ☺");
        
        // Console.WriteLine("Hello Develop03 World!");

        // foreach (var scref in printScript.GetScript()){
        //     Console.WriteLine(scref.Key);
        //     Console.WriteLine(scref.Value);
        //}
    }
}