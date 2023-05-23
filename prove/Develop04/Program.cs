using System;

class Program
{
    static void Main(string[] args)
    {   
        
        int _usersel= 0;
        List<string> menu = new List<string>
            {
                "Menu options:",
                "   1.Start breathing activity",
                "   2.Start reflecting activity",
                "   3.Start listing activity",
                "   4.Quit",
                "Select an option:"
            };
            while(_usersel != 4)
            {
                foreach (string item in menu)
                {
                    Console.WriteLine(item);

                }
                _usersel = int.Parse(Console.ReadLine());
                if (_usersel == 1)
                {
                    Console.Clear();
                    Activity new_ = new Activity(_usersel);
                    BrActivity neww = new BrActivity(_usersel);
                    neww.BrInBrOut();
                    neww.EndMessage();

                }
                else if (_usersel == 2)
                {
                    Console.Clear();
                    RefActivity nac = new RefActivity(_usersel);
                    nac.DisplayPrompandQuest();
                    nac.EndMessage();
                }
                else if (_usersel ==3)
                {
                    Console.Clear();
                    ListActivity nlact = new ListActivity(_usersel);
                    nlact.ListinTHings();
                    nlact.EndMessage();

                }
                 

            }

    }
}