using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
       //essential variables 
       bool hidden = false; 
       string userInput = ""; 
       Random random= new Random();
       Scripture s= new Scripture("John", "3", "16");
       Reference r= new Reference();
       Word wordInstance = new Word(); 
    
       string scripture = r.GetReference();
       //Creating a string array to turn into a list of words
       string scriptureString= ("For God so loved the world that he gave His only begotten son, that whosoever believeth in Him should not perish, but have everlasting life.");
       string[] _words = scriptureString.Split(" ");   

       List<Word> _ws = new List<Word>();
       foreach(string word in _words) {
            Word w= new Word(word);
            _ws.Add(w);
       }
       do {
            Console.Write($"{scripture} ");
            foreach(Word ws in _ws) {
                ws.PrintWords();
            }
           
            Console.WriteLine("Press Enter to continue or type quit to end program.");
            userInput= Console.ReadLine();
            int r1 = random.Next(0, _ws.Count);
            int r2 = random.Next(0, _ws.Count);
            int r3 = random.Next(0, _ws.Count);
            _ws[r1]= new Word("___");
            _ws[r2]= new Word("___");
            _ws[r3]= new Word("___");
            Console.Clear();
            foreach (Word ws in _ws) {
                wordInstance.SetHiddenTrue(ws);
            }
            
            hidden = wordInstance.IsHidden();
            
        } while ((userInput != "quit") || (hidden == true));
       
    }
}