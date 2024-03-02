using System;

public class Listing : Activity {

    private int _delay;
    
    public List<string> _promptsList = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing() {

    }

  
    public Listing(string activity, string description, int duration) : base(activity, description, duration) {
        _delay = duration;
    }

    public void DisplayListMessage() {
        int responses = 0;
        string prompt = GenerateRandomPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDelay());
        Console.WriteLine(prompt);
        Console.WriteLine("Begin thinking...");
        Thread.Sleep(7000);
        Console.WriteLine("Begin writing!");
        while (DateTime.Now < endTime) {
            Console.ReadLine();
            responses++;
            Console.Write("\b \b");
        }
        
        Console.WriteLine(responses);
        responses = 0;
        // Task delayTask = Task.Delay(7000);
        // while (!delayTask.IsCompleted) {
        //     Console.WriteLine(countdown);
        //     Console.Write("\b \b");
        //     countdown--;
        //     if (countdown == 0) {
        //         countdown = 7;
        //     }
        // }
        // while (DateTime.Now < endTime) {
        //    Console.ReadLine();
        //    GetResponseCounter(); 
        // }

    }

   

    public string GenerateRandomPrompt() {
        Random random = new Random();
        int r = random.Next(0, _promptsList.Count);
        if (_promptsList.Count > 0) {
            return _promptsList[r];
        }
        else {
            return "There are no prompts available.";
        }
    }

    public int GetDelay() {
        return _delay;
    }
}