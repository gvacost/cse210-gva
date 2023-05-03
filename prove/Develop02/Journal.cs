using System;
using System.Collections.Generic;

public class Journal

{
    List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
        entries.Append(new Entry("","",""));
        
    }

    public void Display()
    {
      Console.WriteLine(entries);
    }
}