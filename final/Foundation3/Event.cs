
abstract class Event : Address
{
    private string _event_title;
    private string _description;
    private string _date;
    private string _time;
    private string _type_event;
    // private string _address;

    public Event()
    {
    }
    public Event (string type_event, string event_title, string description, string date, string time, string street, string city, string country): base(street, city, country) //string address)
    {
        _event_title = event_title;
        _description = description;
        _date = date;
        _time = time;
        // _address = address;
        _type_event = type_event;

    }


    public string GetTitle()
    {
        return _event_title;
    }
    public void SetTitle(string event_title)
    {
        _event_title = event_title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description; 
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public void StandardDetail()
    {   
        Console.WriteLine($"The {_event_title} a great event.\n{_description}\nWe'll wait for you on {_date} at {_time}");
        GetAddress();       
    }
    public abstract void FullDetail();
    public void ShortDescription()
    {
        Console.WriteLine($"\n{_type_event}\n{_event_title}\n{_date}");
    }
  

}