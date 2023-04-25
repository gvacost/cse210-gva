using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("What is your grade percentage: ");
        string grade = Console.ReadLine();
        float grade_p =float.Parse(grade);
        string l_grade = "";
        if (grade_p>=90)
        {
            l_grade ="A";
            // Console.WriteLine("Your letter grade is A");    
        }
        else if (grade_p>=80 )
        {
            l_grade = "B";
            // Console.WriteLine("Your letter grade is B");
        }
        else if (grade_p>=70)
        {
            l_grade = "C";
            // Console.WriteLine("Your letter grade is C");
        }
        else if (grade_p>=60)
        {
            l_grade = "D";
            // Console.WriteLine("Your letter grade is D");
        }
        else
        {
            l_grade = "F";
            // Console.WriteLine("Your letter grade is F");
        }

        Console.WriteLine($"Your letter grade is {l_grade}");
        
        if (grade_p > 70)
        {
            Console.WriteLine("Congratulations! You´re amazing");
        }
        else
        {
            Console.WriteLine("Don´t worry the next time you will do much better. See you soon!");
        }
    }
}