using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
    int guess = -1;

    Console.WriteLine("Hello Prep3 World!");
    
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 11);

while (guess != magicNumber){
    Console.WriteLine("What is your guess?");
    guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess){
        Console.WriteLine("Higher");
    }
    else if (magicNumber < guess){
        Console.WriteLine("Lower");
    }
    else {
        Console.WriteLine("You got it!! :) ");
    }

    }
    }
}