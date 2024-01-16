using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        Console.WriteLine("Enter a list of numbers. Press 0 when done.");
        int sum = 0;
        int num = 0;
        do {
            Console.WriteLine("Enter a number: ");
            string input= Console.ReadLine();
            num= int.Parse(input);
            if (num != 0) {
                numbers.Add(num);
            }
            
        } while (num != 0);

        for (int i=0; i<numbers.Count(); i++) {
            sum = sum + numbers[i];
        }
        Console.WriteLine($"Sum: {sum}");
        int count= numbers.Count;
        float average = sum / count;
        int max= numbers.Max();
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest number: {max}");
    }
}