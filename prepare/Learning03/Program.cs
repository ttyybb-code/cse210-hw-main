using System;

class Program
{
    static void Main(string[] args)
    {
        void print(string text)
        {
            Console.WriteLine(text);
        }
        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction fraction1 = new Fraction (3, 4);
        Fraction fraction2 = new Fraction(1,3);
        print(one.GetDecimalValue());
        print(one.GetFractionString());
        print(five.GetDecimalValue());
        print(five.GetFractionString());
        print(fraction1.GetDecimalValue());
        print(fraction1.GetFractionString());
        print(fraction2.GetDecimalValue());
        print(fraction2.GetFractionString());

    }
}