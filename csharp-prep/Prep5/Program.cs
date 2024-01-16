using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName= PromptUserName();
        int favoriteNum= PromptUserNumber();
        int squared= SquareNumber(favoriteNum);
        DisplayResult(userName, squared);
    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() {
        Console.WriteLine("Please enter your name: ");
        string input= Console.ReadLine();
        return input;
    }
     static int PromptUserNumber() {
        Console.WriteLine("Please enter your favorite number: ");
        string input= Console.ReadLine();
        int num = int.Parse(input);
        return num;
    }

    static int SquareNumber(int num) {
        int squareNum= num * num;
        return squareNum;
    }
    static void DisplayResult(string userName, int squareNum) {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}.");
    }
}