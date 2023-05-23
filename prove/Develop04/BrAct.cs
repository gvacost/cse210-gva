using System;

class BrActivity : Activity
{
    public BrActivity (int usersel) : base (usersel)
    {

    }

    public void BrInBrOut()
    {
        Activity breact = new Activity(1);
        for (int i = breact.RetTime(); i> 0; i = i-10)
        {
            Console.WriteLine("Breath in..");
            breact.CountDown();
            Console.WriteLine("Breath out..");
            breact.CountDown();
        }
    }
    
}