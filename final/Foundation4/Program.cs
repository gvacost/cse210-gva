using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();

        Running act1 = new Running(30, 1.2, "02 June 2023");
        activities.Add(act1);

        Cycling act2 = new Cycling(40, 25, "03 august 2023");
        activities.Add(act2);

        Swimming act3 = new Swimming(30, 10 ,"18 July 2022");
        activities.Add(act3);

        foreach (Activity acts in activities)
        {
            string data = acts.GetSummary();
        }
    }
}