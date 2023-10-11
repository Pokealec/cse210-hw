using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        Fraction f1 = new Fraction(); // = 1/1

        Fraction f2 = new Fraction(5); // = 5/1

        Fraction f3 = new Fraction(3, 4); // = 3/4

        Fraction f4 = new Fraction(1, 3); // = 1/3

        f1.setFraction(5,6);
        Console.WriteLine($"{f1.getTop()}/{f1.getBottom()}");

        f1.setFraction(1,1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimal());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimal());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimal());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimal());

    }
}