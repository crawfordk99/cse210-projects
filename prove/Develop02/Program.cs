using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program");   
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

            userChoice = Console.ReadLine();
            
            
            switch (userChoice) {
                case "1" :
                // Generate random prompt
                PromptGenerator promptGenerator= new PromptGenerator();
                string prompt= promptGenerator.GenerateRandomPrompt();
                Console.WriteLine(prompt); 
                
                //Getting response and saving it to the response class
                
                string _input = Console.ReadLine();
                DateTime _entryDate = DateTime.Now;
                Response response= new Response(_entryDate, prompt, _input);
                
                journal._entries.Add(response);
    
                break;
            case "2": 
                //Displaying entries in journal
                foreach(Response singleEntry in journal._entries){
                    Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._input}");
                };
                break;
            case "3":
               //Clearing past entries, and loading file entries
               journal._entries.Clear(); 
               Console.WriteLine("Enter Filename: ");
               string fileName1= Console.ReadLine();
               string[] lines = File.ReadAllLines(fileName1);
               foreach(string line in lines) {
                if (line.Trim() != "") {
                    string[] parts= line.Split("|");
                    DateTime date= DateTime.ParseExact(parts[0], "M/d/yyyy", CultureInfo.InvariantCulture);
                    journal._entries.Add(new Response(date, parts[1], parts[2]));
                }
               }
                break;
            case "4":
                // Saving Responses to File
                Console.WriteLine("Enter Filename: ");
                string fileName2= Console.ReadLine();
                File.WriteAllText(fileName2, "");
                foreach(Response item in journal._entries){
                    item.StoreInputToFile(fileName2);
                }
                break;
            case "5":
                // Quit program
                break;
            default:
                Console.WriteLine("Please enter a number between 1 and 5");
                break;
            }
        }
    }   
}