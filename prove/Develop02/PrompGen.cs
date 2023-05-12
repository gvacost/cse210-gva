using System;
using System.Collections.Generic;


public class PromptGen
{
    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };  
   
    public PromptGen()
    {
    }
    
    public string GenPrompts()
    {
              

        Random prompt = new Random();
        int r_prompt = prompt.Next(prompts.Count()); 
        string _rprompt_ = prompts[r_prompt];
        return _rprompt_;
                
        
    }

}