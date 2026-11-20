using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "LP1001", 899.99m, 1));
        order1.AddProduct(new Product("Mouse", "MS2002", 24.99m, 2));
        order1.AddProduct(new Product("Keyboard", "KB3003", 49.99m, 1));

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine();

        // Order 2 - International Customer
        Address address2 = new Address("45 Queen Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Johnson", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "HP4004", 79.99m, 1));
        order2.AddProduct(new Product("Webcam", "WC5005", 59.99m, 1));
        order2.AddProduct(new Product("USB Cable", "UC6006", 9.99m, 3));

        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}