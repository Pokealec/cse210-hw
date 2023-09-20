using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter your numbers.");
        Console.WriteLine("Enter '0' when done.");

    while (input != 0){
        Console.Write("Enter Number: ");
        string userInput = Console.ReadLine();
        input = int.Parse(userInput);

        if (input != 0){
        numbers.Add(input);}
    }
    int sum = 0;
    foreach (int number in numbers){
            sum += number;
        }
    Console.WriteLine($"The sum of your numbers is: {sum}");

    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int max = numbers[0];
        foreach (int number in numbers){
            if (number > max){
                max = number;
        }}
    Console.WriteLine($"The max is: {max}");
    }
}