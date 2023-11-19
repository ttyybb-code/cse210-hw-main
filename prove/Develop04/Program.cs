using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You have selected Breathing Activity.");
                Breathing_activity breathingActivity = new Breathing_activity("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Activity();
                break;
            case 2:
                Console.WriteLine("You have selected Reflection Activity.");
                ReflectionActivity reflectionActivity = new ReflectionActivity("reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.Activity();
                break;
            case 3:
                Console.WriteLine("You have selected Listing Activity.");
                ListingActivity listingActivity = new ListingActivity("listing activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                listingActivity.Activity();
                listingActivity.ShowNumberOfResponses();
                break;
            case 4:
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}
