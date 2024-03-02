using System;

public class Reflection : Activity {
    private int _spinner;
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone in need.",
        "Think of a time you overcame a fear.",
        "Think of a time you did something really difficult.",
        "Think of a time you something truly selfless.",
        "Think of a time you stood up for someone else."
    };
    private List<string> _reflections =new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public Reflection() {
        
    }

    
    public Reflection(string activity, string description, int duration) : base(activity, description, duration) {
        _spinner = duration;
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int r = random.Next(0, _prompts.Count);
         if (_prompts.Count > 0) {
            return _prompts[r];
        }
        else {
            return "There are no prompts available.";
        }
    }
    
    public string GetRandomReflection() {
        Random random = new Random();
        int r = random.Next(0, _reflections.Count);
        if (_reflections.Count > 0) {
            return _reflections[r];
        }
        else {
            return "There are no reflections available.";
        }
        
    }

    public void DisplayReflections() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSpinner());
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        while (DateTime.Now < endTime) {
            string reflection = GetRandomReflection(); 
            Console.WriteLine(reflection);
            foreach(string line in base.DisplayAnimations()) {
                Console.Write(line);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        
        }    
        //     Task delayTask=Task.Delay(5000);
        //     while (!delayTask.IsCompleted) {
        //         string [] animations = base.DisplayAnimations();
        //         Console.WriteLine(animations[i]);
        //         Console.Write("\b \b");
        //         i++;
        //         if (i>animations.Length) {
        //             i = 0;
        //         }
        //     }
        // }    
    }
    public int GetSpinner() {
        return _spinner;
    }
}