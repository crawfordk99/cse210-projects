using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string input= Console.ReadLine();
        int perc= int.Parse(input);
        string letter= "";
        if(perc >= 90){
            letter = "A";
        }
        else if (perc >= 80) {
            letter = "B";
        }
        else if (perc >= 70) {
            letter = "C";
        }
        else if (perc >=60) {
            letter = "D";
        }
        else {
            letter = "F";
        }
        
        if (perc >=70) {
            Console.WriteLine("You passed!");
        }
        Console.WriteLine($"{letter}");
    }
}