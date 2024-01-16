using System;

class Program
{
    static void Main(string[] args) 
    {
        // Console.WriteLine("What is the magic number?");
        Random randNum= new Random();
        int magicNum= randNum.Next(1, 101);
        int guess= -1;
        do {
            Console.WriteLine("What is your guess?");
            string input=Console.ReadLine();
            guess= int.Parse(input);
            if (magicNum > guess) {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNum);
            
    }      
}