using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int m_number = int.Parse(number);
        Console.Write("What is your guess? ");
        string g_number = Console.ReadLine();
        int g_number_ = int.Parse(g_number);

        if (g_number_ > m_number)
        {
            Console.WriteLine("Lower");
        }
        else if (m_number> g_number_)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You got it!");
        }

    }
}