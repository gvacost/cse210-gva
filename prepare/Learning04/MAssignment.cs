using System;

class MAssignment : Assignment
{
    private string _textselect;
    private string _problems; 
    
    public MAssignment(string studentname, string topic, string textselect , string problems) : base (studentname, topic)
    {
        _textselect = textselect;
        _problems = problems; 

    }

    public string GetHomeWorkList()
    {
        return $"Section {_textselect} Problems {_problems}";
    }
}