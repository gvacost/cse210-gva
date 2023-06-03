class Cycling : Activity
{
    private double _cspeed;
    private string _cycling_data, c_date;
    private double _cdistance, _cpace;
    private int _ctime;

    public Cycling()
    { 
    }
    public Cycling(int time, double speed, string date) : base (time)
    {
        _cspeed = speed;
        _ctime = time;
        c_date = date;
    }

    public override string Calculations()
    {   
        _cdistance = (_ctime * _cspeed)/60;
        _cpace = 60/_cspeed;
        _cycling_data = $"{c_date} Cycling ({_ctime} min.) - Distance {double.Round((_cdistance), 1)} km, Speed {double.Round((_cspeed),1)} kph, Pace: {double.Round((_cpace),1)} min per km";

        return _cycling_data;
    }
   
}