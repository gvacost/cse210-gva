
class OutdoorGatherings : Event
{
    private string _weather_statement;

    public OutdoorGatherings()
    {
    }
    public OutdoorGatherings(string type_event, string event_title, string description, string date, string time, string weather_statement, string street, string city, string country) : base (type_event, event_title, description, date, time, street, city, country)
    {
        _weather_statement = weather_statement;
    }

    public override void FullDetail()
    {
        Console.WriteLine($"The {GetTitle()} a great event. \n{GetDescription()}\nWe'll wait for you on {GetDate()} at {GetTime()}\n{_weather_statement}");
    }
    

}