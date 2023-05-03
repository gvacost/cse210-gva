using System;
using System.Collections.Generic;


public class PromptGen
{
    List<string> prompts = new List<string>();

   
    public PromptGen()
    {
    }
    
    public void GenPrompts()
    {
        {
            prompts.Add("Who was the most interesting person I interacted with today? ");
            prompts.Add("What was the best part of my day? ");
            prompts.Add("How did I see the hand of the Lord in my life today? ");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
        }          

            Random prompt = new Random();
            int r_prompt = prompt.Next(1,5); 
                if (r_prompt == 1)
                {
                    Console.WriteLine(prompts[0]);
                    
                }
                else if (r_prompt == 2)
                {
                    Console.WriteLine(prompts[1]);
                }
                else if (r_prompt == 3)
                {
                    Console.WriteLine(prompts[2]);
                }
                else if (r_prompt == 4)
                {
                    Console.WriteLine(prompts[3]);
                }
                else
                {
                    Console.WriteLine(prompts[4]);
                }
            
        
    }

}