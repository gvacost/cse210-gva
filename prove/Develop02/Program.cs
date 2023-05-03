using System;

class Program
{
    static void Main(string[] args)
    {
        int _userselect = 0;
        Journal mjournal = new Journal();
          List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit", 
                "What would you like to do?"  
            };
            while(_userselect !=5)
            {
                foreach(string itemenu in menu)
                {
                    Console.WriteLine(itemenu);
                }
                _userselect = int.Parse(Console.ReadLine());
                if (_userselect == 1)
                {
                    Entry prompt = new Entry( "","","");
                    prompt.RandomPrompt();
                }
                else if (_userselect == 2)
                {
                    Journal mjour = new Journal();
                    mjour.Display();
                }
            }    
        
    } 
}