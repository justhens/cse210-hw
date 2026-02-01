using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "456 Cornhusker Rd",
            "Lincoln",
            "NE",
            "USA"
        );
        Customer customer1 = new Customer("Alex Martinez", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Basketball Jersey", "101", 59.99, 1));
        order1.AddProduct(new Product("Athletic Shorts", "102", 29.99, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\n------------------------\n");

        Address address2 = new Address(
            "123 Reforma Ave",
            "Mexico City",
            "CDMX",
            "Mexico"
        );
        Customer customer2 = new Customer("Luis Hernandez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Soccer Cleats", "201", 89.99, 1));
        order2.AddProduct(new Product("Training Jacket", "202", 74.50, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");

        Console.WriteLine("\n------------------------\n");

        Address address3 = new Address(
            "789 Broadway",
            "New York",
            "NY",
            "USA"
        );
        Customer customer3 = new Customer("Jordan Lee", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Running Shoes", "301", 120.00, 1));
        order3.AddProduct(new Product("Compression Socks", "302", 18.50, 3));
        order3.AddProduct(new Product("Baseball Cap", "303", 24.00, 1));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.GetTotalPrice()}");
    }
}
