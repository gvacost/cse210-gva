using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent event1 = new LectureEvent("Lecture Event", "Welcome to Lecture", "Talking about Lecture", "10 July", "13:00 UTC-3", "Gonzalo Acosta", 50, "Street 1", "Olavarria", "Argentina");
        // Address add1 = new Address("street 1", "SomeLand","SomePlace in World");
        event1.StandardDetail();
        event1.FullDetail();
        event1.ShortDescription();

        Receptions event2 = new Receptions("Reception Event", "Receptions", "A beautiful gathering", "April 23", "14:15 UTC-3", "rsvpnow@receptions.com", "Street 2 and Gold Av.", "Buenos Aires", "Argentina");
        event2.StandardDetail();
        event2.FullDetail();
        event2.ShortDescription();

        OutdoorGatherings event3 = new OutdoorGatherings("OutdoorGathering", "Enjoying nature", "Take a breakfast in the garden", "January 10", "17:00 UTC-3", "It will not canceled by rain", "Street 3", "Necochea", "Argentina");
        event3.StandardDetail();
        event3.FullDetail();
        event3.ShortDescription();
    }
}