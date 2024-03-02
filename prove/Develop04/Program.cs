using System;

class Program
{
    static async Task Main(string[] args)
    {   
        
        Breathing breathe = new Breathing();
        Reflection reflect = new Reflection();
        Listing list = new Listing();
        
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
                Console.WriteLine("Please enter desired number of seconds for Breathing Activity: ");
                string input = Console.ReadLine();
                seconds = int.Parse(input);

                breathe = new Breathing("Breathing", "The breathing activity will give you a chance " +
                "to practice deep breathing for however long you want. It will alternate " +
                "between breathe in and breathe out with a pause in between. It will end " +
                "when it reaches the duration you requested. Clear your mind and focus.", seconds);
                
                Console.WriteLine(breathe.GetDescription());
                breathe.DisplayMessage();
                break;
            case "2":
                Console.WriteLine("Please enter desired number of seconds for Reflection activity");
                input = Console.ReadLine();
                seconds= int.Parse(input);
                reflect = new Reflection("Reflection", "The reflection activity will help you to " +
                "recognize when you have been strong in life. It will give you a series of " + 
                "prompts to help you reflect on it. Remember the power you have and how you " +
                "can use it in other aspects of your life. ", seconds);
                Console.WriteLine(reflect.GetDescription());
                reflect.DisplayReflections();
                break;
            case "3":
                Console.WriteLine("Please enter desired number of seconds for Listing activity");
                input = Console.ReadLine();
                seconds= int.Parse(input);
                list = new Listing("Listing", "The listing activity will help you to recognize the" +
                "good things in your life by having you list as many things in a certain area.", seconds);
                Console.WriteLine(list.GetDescription());
                list.DisplayListMessage();
                break;
            case "4": 
                break;
        }
        Console.WriteLine("Thanks for practing your mindfulness! Try to make it a daily habit!");
    }
}