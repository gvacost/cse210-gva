using System.Collections.Generic;
class SavesLoads
{


    public SavesLoads()
    {
        
    }

    public static void SaveToFile(List<string> _goalstosave , string tosave)
    {

      using (StreamWriter output = new StreamWriter(tosave))
      {
        foreach (string goal in _goalstosave)
        {
            output.WriteLine(goal);
            return;
        }

      }
    }
}