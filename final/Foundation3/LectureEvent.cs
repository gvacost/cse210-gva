
class LectureEvent : Event
{
    private string _speaker_fullname;
    private int _capacity;

    public LectureEvent()
    {
    }
    public LectureEvent(string type_event,string event_title, string description, string date, string time, string speaker_fullname, int capacity, string street, string city, string country) : base ( type_event, event_title, description, date, time, street, city, country)
    {
        _speaker_fullname = speaker_fullname;
        _capacity = capacity;
    }
  
    public void GetSpeaker()
    {
        Console.WriteLine($"Speaker: {_speaker_fullname}");
    }
    public void GetCapacity()
    {
        Console.WriteLine($"Limit Capacity: {_capacity}");
    }

    public override void FullDetail()
    {
        Console.WriteLine($"The {GetTitle()} a great event. \n{GetDescription()}\nWe'll wait for you on {GetDate()} at {GetTime()}");
        GetSpeaker();
        GetCapacity();
    }
}