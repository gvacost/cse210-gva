
class EternalGoal : Goal
{

    private const int _typeofgoal =2;
    private bool _gcomplete;

    public EternalGoal()
    {

    }
    public EternalGoal (string name, string description, int points, bool gcomplete) : base (name, description, points)
    {
        _gcomplete = gcomplete;
    }
    
     public override string ToCSVRecord()
     {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _typeofgoal, GetName(), GetDescription(), GetGoalPoint(), _gcomplete);

     }
      
    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((_gcomplete == false)? " ": "X"), GetName(), GetDescription());
    }

    public override void Record()
    {
        Console.WriteLine(string.Format("Congratulations! You have earned {0}", GetGoalPoint()));
        _gcomplete = true;
    }
}