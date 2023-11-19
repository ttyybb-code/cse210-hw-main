using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter a list of numbers, enter 0 when finished: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
                {
                    numbers.Add(number);
                }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is {sum}");

        float avrage = (float)sum / numbers.Count;
        Console.WriteLine($"The avrage of the numbers is {avrage}");

        int highest = numbers[0];
        foreach(int num in numbers)
        {
            if (num > highest)
            {
                highest = num;
            }
        }
        Console.WriteLine($"The highest number entered was {highest}");
    }
}