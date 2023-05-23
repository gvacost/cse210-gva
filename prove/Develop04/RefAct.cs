using System;

class RefActivity : Activity
{

    public RefActivity(int usersel) : base (usersel)
    {

    }

    public void RandPrompt()
    {
        List<string> l_r_prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        
        Random prompt = new Random();
        int r_prompt = prompt.Next(l_r_prompt.Count()); 
        string _rprompt_ = l_r_prompt[r_prompt];
        Console.WriteLine(_rprompt_);
    }    

    public void DisplayPrompandQuest()
    {
        List<string> quests = new List<string>
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


        Activity nq = new Activity(2);
        // Console.Write("Please type 'Enter' when you have somthing in mind");
        // string sel_=null;
       
        int time_ = nq.RetTime();
        RandPrompt();
        nq.CountDown();
        for (int i = time_; i> 0; i = i-10)
        {
            Random quest = new Random();
            int r_quest = quest.Next(quests.Count()); 
            string _rquest_ = quests[r_quest];
            Console.WriteLine(_rquest_);
            nq.Animation();
            Console.Clear();
        }
           
    }

}