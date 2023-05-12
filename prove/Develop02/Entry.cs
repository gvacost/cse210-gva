using System;


public class Entry
{
    public string  rprompt;
    public string  datedata;
    public string  prompt_response;

    public Entry(string _rprompt, string _datedata, string _prompt_response)
    {
        rprompt = _rprompt;
        datedata = _datedata;
        prompt_response = _prompt_response;
    }
    public string GetEntries()
    {
        string entrie = ($"{datedata}-{rprompt}-{prompt_response}");
        return entrie;
    } 
  public string EntryAsCSV()
  {
    return string.Format("{0}{1}{2}", datedata, rprompt, prompt_response);
    

  }
    
   

 
    public void DisplayEntry()
    {
        Console.WriteLine($"{datedata}-{prompt_response}");
       
    }
    
}
