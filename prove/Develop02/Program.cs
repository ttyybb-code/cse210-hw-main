using System;
using System.Threading;
// To exceed requierments I have the program wait after displaying the file and used switch instead of if/then statments
// I also used an array istead of a list in the promptgenerator
class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Write to Journal");
            Console.WriteLine("2) Read Journal");
            Console.WriteLine("3) Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    entry.Main();

                    break;
                case "2":
                    journal.Display();
                    Thread.Sleep(5000);
                    break;
                case "3":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
    }
}