
class CheckListGoal : Goal
{
    private const int _typeofgoal = 3;
    // private int _completepoints = 0;
    private int _glength = 0;
    private int _goalTracking = 0;
    private bool _gcomplete;

    public CheckListGoal()
    {
        DisplayGetName();
        DisplayGetDescription();
        DisplayGetGoalPoint();
        GetGoalLength();
        DisplayGetBonus();
        
    }
    public CheckListGoal(string name, string description, int points, bool gcomplete) : base (name, description, points)
    {
        _gcomplete = gcomplete;
    }
  
    public void GetGoalLength()
    {
        Console.Write("How many times do you need to accomplish this goal? ");
        _glength = int.Parse(Console.ReadLine());
        
    }
    public int DGoalLength()
    {
        return _glength;
    }
         public override string ToCSVRecord()
     {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _typeofgoal, GetName(), GetDescription(), GetGoalPoint(), _gcomplete);

     }
      
    public override string ToString()
    {
        return string.Format("[{1}/{2}] {3} ({4})", ((_gcomplete == false)? " ":"X"), _goalTracking, _glength, GetName(), GetDescription());
    }
    // public int RetGoalTracking()
    // {
    //     _goalTracking ++;

    //     return _goalTracking;
    // }

    public override void Record()
    {
        _goalTracking ++;       
        
        if (_goalTracking == _glength)
        {
            Console.WriteLine(string.Format("Congratulations! You have earned {0}", GetGoalPoint() + GetBonus())); 
            
        }
    }
}