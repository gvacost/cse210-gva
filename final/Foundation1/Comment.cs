using System;


class Comments
{
    public string _name1, _name2, _name3;
    public string _comment1, _comment2, _comment3;
    public string _fullcomment1, _fullcomment2, _fullcomment3;
    

    public List<Video> videos = new List<Video>();
    public List<string> comments1 = new List<string>();
    public List<string> comments2 = new List<string>();
    public List<string> comments3 = new List<string>();
    public List<string> comments4 = new List<string>();

    public Comments()
    {

    }

    public void DisplayComment1()
    {
        // Console.WriteLine($"{_name}:{_comment}");
        _fullcomment1 = $"{_name1}:{_comment1}";
    }
    public void DisplayComment2()
    {
        _fullcomment2 = $"{_name2}:{_comment2}";
        return;
    }
    public void DisplayComment3()
    {
        _fullcomment3 =$"{_name3}:{_comment3}";
        return;
    }
    public void SaveComents1()
    {
        comments1.Add(_fullcomment1);
        return;
    }
    public void SaveComents2()
    {
        comments2.Add(_fullcomment2);
        return;
        
    }
    public void SaveComents3()
    {
        comments3.Add(_fullcomment3);
        return;
    }
       public void DisplayVideo()
    {
        foreach (Video video in videos)
        {
            video.DisplayDataVideo();
            if (video == videos[0])
            {
                Console.WriteLine($"This video has {comments1.Count()} comments. Which are:");
                foreach (string comment in comments1)
                {
                    Console.WriteLine(comment);
                }
            }
            else if (video == videos[1])
            {
                Console.WriteLine($"This video has {comments2.Count()} comments. Which are:");
                foreach (string comment in comments2)
                {
                    Console.WriteLine(comment);
                }
            }
            else if (video == videos[2])
            {   
                Console.WriteLine($"This video has {comments3.Count()} comments. Which are:");
                foreach (string comment in comments3)
                {
                    Console.WriteLine(comment);
                }
            }
        }
    }
}
