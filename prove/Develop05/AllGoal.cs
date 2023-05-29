

class Allgoals
{
    private List<Goal> goals = new List<Goal>();
    private int _totalpoints;

    public int GetPoint()
    {
        return _totalpoints;
    }
    public void DisplayPoints()
    {
        Console.WriteLine(string.Format("You have {0} points.\n", _totalpoints));
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (goals.Count()== 0)
        {
            Console.WriteLine("You have not goals yet.");
        }
        foreach(Goal goal in goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public void SaveGoals()
    {
        if (goals.Count()== 0)
        {
            Console.WriteLine("No goals to save");
            return;
        }

        string _toSave = DisplayGoalFile();

        List<string> goalstoSave = new List<string>();
        goalstoSave.Add(_totalpoints.ToString());

        foreach (Goal goal in goals)
        {
            goalstoSave.Add(goal.ToCSVRecord());
        }
        
        SavesLoads.SaveToFile(goalstoSave, _toSave);
    
        
        
 
        Console.WriteLine("Goals saved");
    }

    public void LoadGoals()
    {
        List<string> fileGoals;

        fileGoals = System.IO.File.ReadAllLines(DisplayGoalFile()).ToList();

        Goal goal = null;

        foreach (string goalIn in fileGoals)
        {
            string [] goalparts = goalIn.Split('|');
            int _typeofgoal = int.Parse(goalparts[0]);
            switch(_typeofgoal)
            {
                case 1: 
                    goal = new SimpleGoal(goalparts[1], goalparts[2], int.Parse(goalparts[3]), bool.Parse(goalparts[4]));
                    break;
                case 2:
                    goal = new EternalGoal(goalparts[1], goalparts[2], int.Parse(goalparts[3]), bool.Parse(goalparts[4]));
                    break;
                case 3:
                    goal = new CheckListGoal(goalparts[1], goalparts[2], int.Parse(goalparts[3]), bool.Parse(goalparts[4]));
                    break;
            }
            if (goal != null && goals.Contains(goal)== false)
            {
                goals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded.\n");
    }

    public string DisplayGoalFile()
    {
        Console.Write("What is the filename for the goal file? ");
        return Directory.GetCurrentDirectory()+ Console.ReadLine();  //+"\\Files\\"
    }

    public void Records()
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(string.Format("{0}-{1}", goals.IndexOf(goal) + 1, goal.GetName()));
        }
        Console.WriteLine("Which goal did you accomplish? ");
        int _record = int.Parse(Console.ReadLine()) - 1;
        goals[_record].Record();
        _totalpoints +=goals[_record].GetGoalPoint();

        // CheckListGoal nb = new CheckListGoal();
        
        // if (nb.DGoalLength()== nb.RetGoalTracking())
        // {
        //     _totalpoints = _totalpoints + goals[_record].GetBonus();
        // }

        Console.WriteLine(string.Format("You now have {0} points.", _totalpoints.ToString()));        
    }
}