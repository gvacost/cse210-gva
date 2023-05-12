using System;

class Program
{
    static void Main(string[] args)
    {
        Reference nscr = new Reference("Jhon","2","2","3");
        Scriptures nscripture = new Scriptures(nscr, "And when they wanted wine, the mother of Jesus saith unto him, They have no wine."+ 
            "And both Jesus was called, and his disciples, to the marriage.");
        string _user = "";

        while (_user != "quit" && nscripture.HasWordsLeft() == true)
        {
            Console.Clear();            // Me limpia la terminal basicamente y deja unicamente lo que ponga abajo
            Console.WriteLine(nscripture.GetHScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            _user = Console.ReadLine();
            nscripture.Remove();
        }
        Console.WriteLine("Congrats! You memorized the scripture");
    }
}