using System;

class Program
{
    static void Main(string[] args)
    {
        displaymessage();
        string username = promptusername();
        int usernumber = promptusernumber();
        int squared =  square(usernumber);
        displayresult(username, squared);
    }
    static void displaymessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string promptusername()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int promptusernumber()
    {
        Console.Write("What is your number? ");
        string num = Console.ReadLine(); 
        int number = int.Parse(num);

        return number;
    }

    static int square (int number)
    {
        
        int sq_number = number * number;

        return sq_number;

    }

    static void displayresult(string name, int sq_number)
    {
        Console.WriteLine($"{name}, the square of your number is {sq_number}");
    }
}

// Finally I follow the sample solution because I could not find my mistake