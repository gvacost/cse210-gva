using System;

class ListActivity : Activity
{
    public ListActivity(int usersel) : base (usersel)
    {

    }
    public void ListinTHings()
    {
        List<string> listprompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Activity nlact = new Activity(3);
        int time_ = nlact.RetTime();
        Random lact = new Random();
        int lprompt = lact.Next(listprompt.Count());
        string randprompt = listprompt[lprompt];       
        Console.WriteLine(randprompt);
        nlact.CountDown();
        List<string> listitems = new List<string>();
        string addresponse;
        DateTime countime = DateTime.Now;
        DateTime endtime = countime.AddSeconds(time_);
        while (DateTime.Now < endtime)
        {
            Console.Write("-");
            addresponse = Console.ReadLine();
            listitems.Add(addresponse);
        }

        Console.WriteLine($"You Listed {listitems.Count()} items!");
    }

}