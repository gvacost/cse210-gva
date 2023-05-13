using System;
using System.Collections.Generic;
using System.IO;

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

    public void LoadToCSV()
    {
      Console.WriteLine("What is the name of the file? ");
      string filename = Console.ReadLine();
      filename.Remove(filename.Count());
    

    }

    public void SaveToCSV()
    {
      string  _filen = "entries.txt";

      using (StreamWriter output = new StreamWriter(_filen))
      {
            foreach (Entry entrie in entries)
            {
                output.WriteLine($"{entrie.datedata}-{entrie.rprompt}");
                output.WriteLine(entrie.prompt_response);
            }

        }
      
    }

  
    public static List<Entry> Display()
    {
      Console.WriteLine("Reading the file...");
      List<Entry> disp_ = new List<Entry>();
      string _filen = "entries.txt";

      string [] _nlist = System.IO.File.ReadAllLines(_filen);
      foreach (string line in _nlist)
      {
        Console.WriteLine(line);
      }
      return disp_;
    }
}