using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage");
        string grade = Console.ReadLine();
        float grade_p =float.Parse(grade);
        if (grade_p>=90)
        {
            Console.WriteLine("Then your grade is A");    
        }
        else if (grade_p>=80 )
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (grade_p>=70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (grade_p>=60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }

         
    }
}