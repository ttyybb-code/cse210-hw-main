using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        char gradeLetter;
        Console.Write("Enter your grade %: ");
        string userInputGrade = Console.ReadLine();

        float gradePercent = float.Parse(userInputGrade);
        
        if (gradePercent >= 90)
        {
            gradeLetter = 'A';
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = 'B';
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = 'C';
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = 'D';
        }
        else
        {
            gradeLetter = 'F';
        }
        Console.WriteLine($"You got a {gradeLetter}");
        if( gradePercent >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}