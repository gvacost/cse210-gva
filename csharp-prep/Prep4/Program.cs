using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        float number = float.Parse(num);
        List <float> numbers = new List<float>();
        
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            num = Console.ReadLine();
            number = float.Parse(num);
        }
        
        Console.WriteLine($"The sum is {numbers.Sum()}");
        // Console.WriteLine($"The average is {numbers.Average()}");
    }
}