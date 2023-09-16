using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90){
            letter = "A";
        }
        else if (percent >= 80){
            letter = "B";
        }
        else if (percent >= 70){
            letter = "C";
        }
        else if (percent >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"You got a(n) {letter}");

        if (percent > 70){
            Console.WriteLine("You passed! Great Job!");
        }
        else{
            Console.WriteLine("You failed. Maybe try extra credit?");
        }

    }
}