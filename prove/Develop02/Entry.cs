using System;


public class Entry
{
    public string _rprompt, rprompt;
    public string _datedata, datedata;
    public string _prompt_response, prompt_response;

    public  Entry(string _rprompt, string _datedata, string _prompt_response)
    {
        rprompt = _prompt_response;
        datedata = _datedata;
        prompt_response = _prompt_response;
    }

    public void DateData()

    {
        DateTime date = DateTime.Now;
        _datedata = date.ToShortDateString();
       
    }
    public void RandomPrompt()
    {
        PromptGen _rprompt_ = new PromptGen();
        _rprompt_.GenPrompts();
        _prompt_response = Console.ReadLine();
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{datedata}-{prompt_response}");
       
    }
    
}
