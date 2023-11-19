using System;

//to exceed requirements, I made it so that the program cannot hide a word twice.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string verse = "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";
        string[] words = verse.Split(" ");
        for(int i = 0; i < words.Length; i ++)
        {
            Word word = new Word(words[i]);
            scripture.addWord(word);
        }
        string book = "Proverbs";
        string chapter = "3";
        string firstVerce = "5";
        string lastVerce = "6";
        Refrence refrence = new Refrence(book, chapter, firstVerce, lastVerce);
        string quit = "";
        for (int i = words.Length; i >= 0; i -= 3)
        {
            scripture.Show(refrence);
            Console.WriteLine();
            Console.WriteLine("Press enter, or type 'quit' to quit");
            quit = Console.ReadLine();
            if (quit == "quit")
            {
                break;
            }
            else
            {
                scripture.hideWords();
            }
        }
        
        
        

    }
}