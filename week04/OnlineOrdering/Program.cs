using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Apple street", "Filnt", "Lagos", "Nigeria.");
        Customer customer1 = new Customer("Daniel Olamide", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Notebook","N123", 3.5, 4),
            new Product("Pen", "P456", 1.2, 10)

        };
        
        Order order1 = new Order(customer1, products1);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packaging Label:");
        Console.WriteLine(order1.PackagingLabel());
        Console.WriteLine($"Total Price: ${order1.Total():F2}\n");

        Console.WriteLine("");

        Address address2 = new Address("123 hinder street", "Finil", "Oaklahoma", "USA.");
        Customer customer2 = new Customer("Joe Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Notebook","N123", 3.5, 4),

            new Product("Pen", "P456", 1.2, 10),

        };
        
        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packaging Label:");
        Console.WriteLine(order2.PackagingLabel());
        Console.WriteLine($"Total Price: ${order2.Total():F2}\n");


        //order1.Display();

    }
}
