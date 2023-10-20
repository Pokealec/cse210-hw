using System;
// Changes rand item in selected scripture into a blank space "_____"

public class RemoveWord
{
    private List<string> textlist = new();
    private int wordsRemoved = 0;

    public int GetWordsRemoved()
    {
        return wordsRemoved;
    }
    public void convertToList(string text){
        List<string> words = text.Split(' ').ToList(); // Changes each word in string to be entries in a list
        textlist = words; // puts new word list into textlist
    }

    public List<string> getTextList(){
        return textlist;
    }

    public void printlist(){
        foreach(string word in textlist){
            Console.Write($"{word} "); // this writes each word in the list in order, reincluding a space after each one.
        }
    }
    private int Randword(){
        var random = new Random();
        int index = random.Next(textlist.Count);
        return index;
    }
    public void RemoveDaWords(){
        int index;
        do index = Randword(); while(textlist[index].Contains('_'));
        textlist[index] = new string('_', textlist[index].Length);
        wordsRemoved += 1;
        printlist();
        Console.Write($"\n{wordsRemoved} out of {textlist.Count} removed.");
    }

}