using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 main st.", "New York", "New York", "USA");
        Address address2 = new Address("520 st.", "New Donk", "Metro", "Mario");
        Customer customer1 = new Customer("John", address1);
        Customer customer2 = new Customer("Pauline", address2);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Product moon = new Product("Moon", 1234, 19.84);
        Product star = new Product("Star", 1235, 19.86);
        Product cap = new Product("Cap", 1001, 19.99);
        Product apple = new Product("Apple", 1111, 1.95);
        Product milk = new Product("Milk", 1100, 3.25);
        Product chips = new Product("Chips", 1101, 4.99);

        order2.AddProduct(moon, 15);
        order2.AddProduct(star, 2);
        order2.AddProduct(cap, 1);

        order1.AddProduct(apple, 10);
        order1.AddProduct(milk, 1);
        order1.AddProduct(chips, 2);

        Console.WriteLine("Order 1");
        Console.WriteLine("");

        order1.CalculatePrice();
        order1.MakePackingLabel();
        order1.MakeShippingLabel();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order1.GetPrice()}");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());


        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.WriteLine("Order 2");
        
        
        order2.CalculatePrice();
        order2.MakePackingLabel();
        order2.MakeShippingLabel();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order2.GetPrice()}");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());

    }
}