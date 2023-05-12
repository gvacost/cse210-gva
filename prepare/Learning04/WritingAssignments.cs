using System;

class WritingAssignment : Assignment
{
    private string _title;

public WritingAssignment (string studentname, string topic, string title) : base (studentname, topic)
{
    _title = title;
}

public string GetWritingInfo()
{
string studentname = GetName();

return $"{_title} by {studentname}";
}


}