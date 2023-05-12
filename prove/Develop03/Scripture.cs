using System;
using System.Collections.Generic;


class Scripture
{
    List<string> scrip = new List<string> 
    {
        "Your list of scriptures is this:"
    };
    
    private string _book, _chapter, _versicle, _scrip, _sescrip;
    private int _num = 0;

    public Scripture()
    {

    }

    public Scripture(string book, string chapter, string versicle)
    {
        book = _book;
        chapter = _chapter;
        versicle = _versicle;
    }

    public (string, string, string, string) GetScripture()
    {
        Console.Write("Please enter a scripture to learn (type ´no´ if you don´t want to learn any scripture): ");
        _scrip = Console.ReadLine();
        if (_scrip.ToLower() != "no")
        {
            Console.Write("In which book is this scripture? ");
            _book = Console.ReadLine();
            Console.Write("In which chapter? ");
            _chapter = Console.ReadLine();
            Console.Write("What versicle is? ");
            _versicle = Console.ReadLine();
        }
        
            while (_scrip.ToLower() != "no")
            {
                scrip.Add($"{_num+1}-{_scrip}");
                _num++;
                Console.Write("Do you want to see the scriptures saves(yes/no)? ");
                _sescrip = Console.ReadLine();
                if (_sescrip.ToLower() == "yes")
                {
                    foreach (string scr in scrip)
                        {
                            Console.WriteLine(scr);
                        }    
                    Console.Write("Which scripture do you want to learn now? ");
                    _scrip = Console.ReadLine();
                    int selected = int.Parse(_scrip);
                    Console.WriteLine(scrip[selected]);
                    if (selected != 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Enter another scripture: ");
                    _scrip = Console.ReadLine();
                    Console.Write("In which book is this scripture? ");
                    _book = Console.ReadLine();
                    Console.Write("In which chapter? ");
                    _chapter = Console.ReadLine();
                    Console.Write("What versicle is? ");                    
                    _versicle = Console.ReadLine();
                }
            }
            return (_scrip, _book, _chapter, _versicle);
            

    }

    public string Display()
    {
        Console.WriteLine(_scrip);
        return "";
    }
}