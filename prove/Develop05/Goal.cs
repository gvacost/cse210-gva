
abstract class Goal
{

    private string _name, _description;
    private int _points, _completepoints;

    public Goal()
    {
    }

    public Goal ( string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public void DisplayGetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void DisplayGetDescription()
    {
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
    }

    public void DisplayGetGoalPoint()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public void DisplayGetBonus()
    {
        Console.Write("How many points you won when accomplish this goal? ");
        _completepoints = int.Parse(Console.ReadLine());
    }

    public abstract string ToCSVRecord();

    public abstract void Record();

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetGoalPoint()
    {
        return _points; 
    }

    public int GetBonus()
    {
        return _completepoints;
    }

    public override bool Equals(object obj)
    {
        Goal otherGoal = (Goal) obj;
        bool _retvalue = false; 

        if (_name == otherGoal.GetName() && _description == otherGoal.GetDescription())
        {
            _retvalue = true; 
        }
        return _retvalue;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}