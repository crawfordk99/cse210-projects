using System;

class Program
{
    static void Main(string[] args)
    {   
        int seconds = 0;
        Console.WriteLine("Welcome to the program. To help you learn to be mindful we have" +
        " 3 different activities for you to choose from. Choose between a breathing" + 
        " activity, a reflection activity, and a listing activity\n");
        Console.WriteLine("1 - Breathing Activity");
        Console.WriteLine("2 - Reflection Activity");
        Console.WriteLine("3 - Listing Activity");
        Console.WriteLine("4 - Quit\n");
        Console.WriteLine("Please enter a number from the menu: ");
        String userInput = Console.ReadLine();
        
        
        switch (userInput) {
            case "1":
                Console.WriteLine("Please enter desired number of seconds for Breathing Activity");
                String input = Console.ReadLine();
                seconds = Convert.ToInt32(input);
                Breathing breathe = new Breathing();
                
                Activity activity1 = new Activity("Breathing", "The breathing activity will give you a chance " +
                "to practice deep breathing for however long you want. It will alternate " +
                "between breathe in and breathe out with a pause in between. It will end " +
                "when it reaches the duration you requested. Clear your mind and focus.", seconds);
                
                Console.WriteLine(activity1.GetDescription());
                Console.WriteLine();
                break;
            case "2":
                Reflection reflect = new Reflection();
                Activity activity2 = new Activity("Reflection", "The reflection activity will help you to " +
                "recognize when you have been strong in life. It will give you a series of " + 
                "prompts to help you reflect on it. Remember the power you have and how you " +
                "can use it in other aspects of your life. ", seconds);
                break;
            case "3":
                Listing list = new Listing();
                Activity activity3= new Activity("Listing", "The listing activity will help you to recognize the" +
                "good things in your life by having you list as many things in a certain area.", seconds);
                break;
            case "4": 
                break;
        }
    }
}