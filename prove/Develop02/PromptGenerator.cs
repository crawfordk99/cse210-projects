using System.Collections.Generic;

public class PromptGenerator
 
{
    public string[] _prompts = new string[]
    {
        "What got you out of bed this morning?",
        "Describe 1 thing you felt/saw/tasted/smelled/heard today?",
        "Who inspired you today?",
        "What was the strongest emotion I felt today?",
        "If I had 1 thing I could do over today, what would it be?"
    };
    

    public string GenerateRandomPrompt() {
        Random rndPrompt = new Random();
        int r = rndPrompt.Next(_prompts.Length);
        return _prompts[r];
    }
}