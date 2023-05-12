using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        int _userselect = 0;
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
                    journal.CreatEntry();
                
                }
                else if (_userselect == 2)
                {
                    
                    journal.Display();
                }
                else if (_userselect == 3)
                {

                }
                else if (_userselect == 4)
                {
                    
                }
            }    
        
    } 
}