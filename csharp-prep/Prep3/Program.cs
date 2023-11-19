using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber = -10;
        while(magicNumber != guessNumber)
        {Console.Write("Enter a guess: ");
        string guessNumberString = Console.ReadLine();
        guessNumber = int.Parse(guessNumberString);
        if(guessNumber == magicNumber)
            {
                Console.WriteLine("you win");
            }
        else if (guessNumber > magicNumber){Console.WriteLine("you guessed to high");}
        else if (guessNumber < magicNumber ){Console.WriteLine("you guessed to low");}}
    }
}