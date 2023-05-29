using System;
using System.Collections.Generic;
class Menu 
{
    private int selection_;
    private int _gselection;
    private List<string> menu_ = new List<string>()
    {
        "Menu Options: ",
        "1.Create New Goal",
        "2.List Goals",
        "3.Save Goals",
        "4.Load Goals",
        "5.Record Event",
        "6.Quit",
        "Select an option please: "
    };
    public Menu()
    {

    }

    public int DisplayMainMenu()
    {
        foreach (string itemenu in menu_)
        {
            Console.WriteLine(itemenu);
        }    
        selection_ = int.Parse(Console.ReadLine());
        return selection_;
    }
    public int DisplayGetNewGoal()
    {
        List<string> _listofgoals = new List<string>()
        {
            "Types of goals",
            "1.Simple Goal",
            "2.Eternal Goal",
            "3.Checklist Goal"
        };
        foreach (string goals in _listofgoals)
        {
            Console.WriteLine(goals);
        }    
        _gselection = int.Parse(Console.ReadLine());
        return _gselection;
    }
}