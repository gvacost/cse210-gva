using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    

    public Video()
    {

    }

    public void DisplayDataVideo()
    {
        Console.WriteLine($"Title: {_title} - Author: {_author} - Length: {_length} seconds");
    }

 

}