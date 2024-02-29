using System;

public class Breathing : Activity {
    private int _timer;
    public List<Breathing> _messages = new List<Breathing>();
    

    public Breathing() {
        
    }
    public Breathing(string activity, string description, int duration) : base(activity, description, duration) {
        _timer = duration;
        
    }
    
    // public List<string> animations = new List<string>();
    // animations.Add("/");
    // animations.Add("-");
    // animations.Add("\");
    // animations.Add("|");
    // animations.Add("/");
    // animations.Add("-");
    // animations.Add("\");
    // animations.Add("|");

    
    public void DisplayMessage() {
        // int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimer());
        while (DateTime.Now < endTime) {
            // string s = animations[i];
            Console.WriteLine("Breathe in... ");
            Thread.Sleep(8000);
            Console.WriteLine("Breathe out...");

            
            // if (i>animations.Count()) {
            //     i = 0;
            // }
        }
    }

    public int GetTimer() {
        return _timer;
    }
}