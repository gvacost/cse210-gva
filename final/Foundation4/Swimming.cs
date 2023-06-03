class Swimming : Activity
{
    private int _laps;
    private string _swimming_data, s_date;
    private double _sdistance, _space, _sspeed;
    public int _stime;
    public Swimming()
    { 
    }
    public Swimming(int time, int laps, string date) : base (time)
    {
        _laps = laps;
        _stime = time;
        s_date = date;
    }

    public double GetDistance()
    {
        _sdistance = _laps*0.5;
        return _sdistance;
    }
    public override string Calculations()
    {

        _space = _stime/(GetDistance());
        _sspeed = 60/_space;
        _swimming_data = $"{s_date} Swimming ({_stime} min.) - Distance {double.Round((_sdistance),1)} km, Speed {double.Round((_sspeed),1)} kph, Pace: {double.Round((_space),1)}";

        return _swimming_data;

    }
   
}