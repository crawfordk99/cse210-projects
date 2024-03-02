using System;

public class Breathing : Activity {
    private int _timer;

    public Breathing() {
        
    }
    
   
    public Breathing(string activity, string description, int duration) : base(activity, description, duration) {

        _timer= duration;
    }
    

    public int GetTimer() {
        return _timer;
    }   
   
    public void DisplayMessage() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimer());
        while (DateTime.Now < endTime) {
            
            Console.WriteLine("Breathe in... ");
            Console.WriteLine();
            foreach (string line in base.DisplayAnimations()) {
                Console.Write(line);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
           
            Console.WriteLine("Breathe out...");
            foreach(string line in base.DisplayAnimations()) {
                Console.Write(line);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            // Console.Clear(); 
            
            // await Task.Delay(5000);
            // while (true) {
            //     string[] animations = base.DisplayAnimations();
            //     Console.WriteLine(animations[i]);
            //     Console.Write("\b \b");
            //     i++;
            //     if (i>=animations.Length) {
            //         i = 0;
            //     }
            //     if (DateTime.Now >= endTime) {
            //         break;
            //     }
            // }
        }
    }
    
}