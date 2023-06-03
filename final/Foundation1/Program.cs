using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Working with Abstraction";
        video1._author = "Brad Lythgoe";
        video1._length = 430;

        Video video2 = new Video();
        video2._title = "Now, Inheritance";
        video2._author = "Mr. Csharp";
        video2._length = 620;

        Video video3 = new Video();
        video3._title = "Encapsulation? What it is?";
        video3._author = "GVA";
        video3._length = 270;

        Comments comms = new Comments();
        comms._name1 = "Gonzalo Acosta";
        comms._comment1 = "This is great";
        comms.DisplayComment1();
        comms.SaveComents1();        
        comms.videos.Add(video1);
        comms.videos.Add(video2);
        comms.videos.Add(video3);
        comms._name1 = "Valentin Acosta";
        comms._comment1 = "Amazing";
        comms.DisplayComment1();
        comms.SaveComents1();
        comms._name1 ="Ornella Minotti";
        comms._comment1 ="Great JOb";
        comms.DisplayComment1();
        comms.SaveComents1();
        comms._name2 ="Wally Johns";
        comms._comment2 ="This is incredible";
        comms.DisplayComment2();
        comms.SaveComents2();
        comms._name2 ="Magas Smith";
        comms._comment2 ="Is an incredible video";
        comms.DisplayComment2();
        comms.SaveComents2();
        comms._name2 ="Pietro Salvatore";
        comms._comment2 ="È una cosa fantastica. Bravo!";
        comms.DisplayComment2();
        comms.SaveComents2();
        comms._name2 ="Francis Co";
        comms._comment2 ="Is beautiful to have the oporutnity to learn this.";
        comms.DisplayComment2();
        comms.SaveComents2();
        comms._name3 ="Pepe Perez";
        comms._comment3 ="Thank you for this explanation!";
        comms.DisplayComment3();
        comms.SaveComents3();
        comms._name3 ="Jean-Pierre Mukala";
        comms._comment3 ="Great video";
        comms.DisplayComment3();
        comms.SaveComents3();
        comms._name3 ="Gasparov Trnasvski";
        comms._comment3 ="Thanks for all your help";
        comms.DisplayComment3();
        comms.SaveComents3();
        

        // Comments comms2 = new Comments();
        // comms2._name = "Valentin Acosta";
        // comms2._comment = "Amazing";
        // comms2.videos.Add(video2);

        comms.DisplayVideo();



    }
}