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
        while (g_number_ != m_number)
        {
            if (g_number_ > m_number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                g_number = Console.ReadLine();
                g_number_ = int.Parse(g_number);
            }
            else if (m_number> g_number_)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                g_number = Console.ReadLine();
                g_number_ = int.Parse(g_number);
            }
            
        } 
        {
            Console.WriteLine("You got it!");
        }   

    }
}