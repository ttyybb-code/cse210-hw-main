using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1234 south st.", "small town", "ID", "USA");
        Lecture lecture = new Lecture(address, "3:15", "06/12", "a brief lecture", "Lecture", "Lecture", "Prof. Smart", 100);
        Outdoor outdoor = new Outdoor(address, "12:15", "12/12", "an outdoor event", "outdoor event", "outdoor", "sunny");
        Reception reception = new Reception(address, "1:15", "04/02", "a reception", "reception", "reception", "exsample@exsample.com");
        List<Event> events = new List<Event>{lecture, outdoor, reception};

        foreach (Event i in events)
        {
            Console.WriteLine($"{i.StandardDetails()}");
            Console.WriteLine($"{i.FullDetails()}");
            Console.WriteLine($"{i.ShortDescription()}");
        }
    }
}