
class Receptions : Event
{
    private string email_to_rsvp;

    public Receptions()
    {
    }
    public Receptions(string type_event,string event_title, string description, string date, string time, string emailto_rsvp, string street, string city, string country) : base (type_event, event_title, description, date, time, street, city, country)
    {
        email_to_rsvp = emailto_rsvp;
    }

    public void GetRegistration()
    {
        Console.WriteLine($"Please confirm asistance to {email_to_rsvp}");   
    }

    public override void FullDetail()
    {
        Console.WriteLine($"The {GetTitle()} a great event. \n{GetDescription()}\nWe'll wait for you on {GetDate()} at {GetTime()}");
        GetRegistration();
    }
    

}