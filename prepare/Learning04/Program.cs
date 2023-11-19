using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        void print(string text)
        {
            Console.WriteLine(text);
        }
        print(assignment.getSummery());
        print(mathAssignment.getSummery());
        print(mathAssignment.GetHomeworkList());
        print(writingAssignment.getSummery());
        print(writingAssignment.GetWritingInformation());

    }
}