using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)

        Address address1 =
            new Address(
                "123 Main Street",
                "Phoenix",
                "Arizona",
                "USA");

        Customer customer1 =
            new Customer(
                "John Smith",
                address1);

        Order order1 =
            new Order(customer1);

        order1.AddProduct(
            new Product(
                "Laptop",
                "P100",
                800,
                1));

        order1.AddProduct(
            new Product(
                "Mouse",
                "P101",
                25,
                2));

        order1.AddProduct(
            new Product(
                "Keyboard",
                "P102",
                50,
                1));



        // ORDER 2 (International)

        Address address2 =
            new Address(
                "456 Maple Road",
                "Toronto",
                "Ontario",
                "Canada");

        Customer customer2 =
            new Customer(
                "Sarah Johnson",
                address2);

        Order order2 =
            new Order(customer2);

        order2.AddProduct(
            new Product(
                "Monitor",
                "P200",
                300,
                1));

        order2.AddProduct(
            new Product(
                "Webcam",
                "P201",
                80,
                2));

        order2.AddProduct(
            new Product(
                "Headset",
                "P202",
                60,
                1));


        // DISPLAY ORDER 1

        Console.WriteLine("====================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("====================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPRODUCT DETAILS");
        Console.WriteLine(order1.GetOrderDetails());

        Console.WriteLine($"Total Order Price plus shipping: ${order1.GetTotalPrice():F2}");



        // DISPLAY ORDER 2

        Console.WriteLine("\n====================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("====================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPRODUCT DETAILS");
        Console.WriteLine(order2.GetOrderDetails());

        Console.WriteLine($"Total Order Price plus shipping: ${order2.GetTotalPrice():F2}");
    }
}