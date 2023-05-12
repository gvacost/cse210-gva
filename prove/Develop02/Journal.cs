using System;
using System.Collections.Generic;

public class Journal

{
    List<Entry> entries;
    public Journal()
    {
      entries = new List<Entry>();    
      
    }
    public void CreatEntry()
    {
      PromptGen _rpromp = new PromptGen();
      string _rprompt =_rpromp.GenPrompts();

      DateTime data = DateTime.Now;
      string _datedata = data.ToShortDateString();

      Console.WriteLine(_rprompt);

      string _prompt_response = Console.ReadLine();

      Entry entrie = new Entry(_rprompt, _datedata, _prompt_response);
      entries.Add(entrie);
  
    }

    public void SaveToCSV()
    {

    }

    public void LoadToCSV()
    {
      string  _filen = "entries.csv";

      using (StreamWriter output = new StreamWriter(_filen))
      {
        foreach (Journal entrie in entries)
        {
          output.WriteLine(entri);
        }

      }
      
    }

  
    public void Display()
    {
      Console.WriteLine(entries);
    }
}