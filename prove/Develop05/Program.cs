using System;

class Program
{
    static void Main(string[] args)
    {
        // List<string> SimpleNames = new List<string>();
        // string content = File.ReadAllText("SimpleGoals.txt");
        // string[] simpleNameArray = content.Split(';');
        // List<string> EternalNames = new List<string>();
        // content = File.ReadAllText("EternaleGoals.txt");
        // string[] EternalNameArray = content.Split(';');
        // List<string> ChecklistNames = new List<string>();
        // content = File.ReadAllText("ChecklistGoals.txt");
        // string[] checklistNameArray = content.Split(';');

        // for(int i = 0; i < simpleNameArray.Count(); i++)
        // {
            
        // }
        EternalGoal readTheScriptures = new EternalGoal("Read the scriptures");
        SimpleGoal finishReading = new SimpleGoal("Finish Reading the Book of Mormon");
        ChecklistGoal temple = new ChecklistGoal("Visit the temple 5 times");
        User user = new User();
        user.AddGoal(readTheScriptures);
        user.AddGoal(finishReading);
        user.AddGoal(temple);

        while (true)
        {

            Console.WriteLine("Menu:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Mark Simple Goal Complete");
            Console.WriteLine("3. Mark Eternal Goal Complete");
            Console.WriteLine("4. Mark Checklist Goal Complete");
            Console.WriteLine("5. View Score");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");


            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    user.ViewGoals();
                    break;
                case "2":
                    user.GainExp("Finish Reading the Book of Mormon");
                    break;
                case "3":
                    user.GainExp("Read the scriptures");
                    break;
                case "4":
                    user.GainExp("Visit the temple 5 times");
                    break;
                case "5":
                    user.ViewLevel();
                    user.ViewExp();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
}
}