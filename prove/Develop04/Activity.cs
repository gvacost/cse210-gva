using System;

class Activity
{
    // private int _time;
    private int selection;

    public Activity(int usersel)
    {
        selection = usersel;
       
       
    }

    public void Animation()
    {
        List<string> animalist = new List<string>()
            {
                "+",
                "x",
                "+",
                "x",
                "+",
                "x",
                "+",
                "x",
                "+",
                "x"
            };
        foreach (string item in animalist)
        {
            Console.Write(item);
            Thread.Sleep(700);
            Console.Write("\b \b");
        }
    }
    public void CountDown()
    {
        for (int i=5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public string DisplayMessage()
    {

       string valuet_="";

        if (selection == 1)
        {
            
            Console.WriteLine("Welcome to the Breathing Activity: ");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. "+ 
            "Clear your mind and focus on your breathing");

            Console.Write("How long, in seconds, would you like for your session? ");
            string time = Console.ReadLine();
            Console.WriteLine("OK! Let go!");
            
            return  time;
        }
        else if (selection == 2)
        {
            Console.WriteLine("Welcome to the Reflection Activity: ");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. "+
            "This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.Write("How long, in seconds, would you like for your session? ");
            string time = (Console.ReadLine());
            Console.WriteLine("OK! Let go!");
            return time;
        }
        else if (selection == 3)
        {
            Console.WriteLine("Welcome to the Listing Activity: ");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on the good things in your life"+ 
            "by having you list as many things as you can in a certain area.");
            Console.Write("How long, in seconds, would you like for your session? ");
            string time = (Console.ReadLine());
            Console.WriteLine("OK! Let go!");

            return time;
        }
        return valuet_;
    }

    public int RetTime()
    {
        int time_ = int.Parse(DisplayMessage());
        return time_;
    }
    public void EndMessage()
    {
        Console.WriteLine("Well done!");
    }
}