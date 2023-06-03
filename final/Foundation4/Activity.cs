
abstract class Activity
{
    private int _time; 
    public Activity()
    {

    }
    public Activity(int time)
    {
        _time = time;
    }

    public abstract string Calculations();

    public string GetSummary()
    {
        Console.WriteLine(Calculations());
        return "";
    }

}