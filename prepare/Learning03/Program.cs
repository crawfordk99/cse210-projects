using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction getFract1= new Fraction();
        Console.WriteLine(getFract1.GetFractionString());
        Fraction getFract2= new Fraction(6);
        Console.WriteLine(getFract2.GetFractionString());
        Fraction getFract3= new Fraction(3, 4);
        Console.WriteLine(getFract3.GetFractionString());
        Console.WriteLine(getFract3.GetDecimalValue());
        
    }
}