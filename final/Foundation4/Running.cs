
class Running : Activity
{
    private double _rdistance;
    private string _running_data, r_date;
    private double _rspeed, _rpace;
    private int _rtime;
    
    public Running()
    { 
    }
    public Running(int time, double distance, string date) : base (time)
    {
        _rdistance = distance;
        _rtime = time;
        r_date = date;
    }

    public override string Calculations()
    {
        
        _rspeed = (_rdistance/_rtime)*60;
        _rpace = _rtime/_rdistance;
        // DateTime r_date = DateTime.Today;
        _running_data = $"{r_date} Running ({_rtime} min.) - Distance {(double.Round(_rdistance),1)} km, Speed {double.Round((_rspeed),1)} kph, Pace: {double.Round((_rpace),1)} min per km";
        return _running_data;
    }
   
}