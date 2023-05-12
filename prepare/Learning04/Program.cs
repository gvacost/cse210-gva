using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Gonzalo Acosta", "Imaginaries");
        Console.WriteLine(homework.GetSummary());

        MAssignment homework2 = new MAssignment ("Gonzalo Acosta","Division", "5", "2");
        Console.WriteLine(homework2.GetSummary());
        Console.WriteLine(homework2.GetHomeWorkList());

        WritingAssignment homework3 = new WritingAssignment("Gonzalo Acosta", "Pipes", "Steel Pipes");
        Console.WriteLine(homework3.GetSummary());
        Console.WriteLine(homework3.GetWritingInfo());
    }
}