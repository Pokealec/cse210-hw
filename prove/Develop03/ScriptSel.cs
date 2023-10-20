using System;
// selects a random scripture from the ScriptText list so that words can be removed
public class ScriptSel
{

    public int _scriptindex;  

    public string RandScript(Dictionary<string, string> dict)
    {
        Random random = new();
        int index = random.Next(0, dict.Count);
        Console.WriteLine(dict.ElementAt(index).Key); // prints title (scripture ref)
        return dict.ElementAt(index).Value; // Prints the scripture
    }

    // return rand scripture from list

}