using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear productos
        Product product1 = new Product("Laptop", 404, 1200m, 1);
        Product product2 = new Product("Smartphone", 200, 800m, 2);
        Product product3 = new Product("Smart TV", 205, 500m, 3);
        Product product4 = new Product("Headphones", 155, 200m, 4);

        // Crear direcciones
        Address addressUSA = new Address("1234 Elm Street", "Springfield", "IL", "USA");
        Address addressCanada = new Address("5678 Maple Avenue", "Toronto", "ON", "Canada");

        // Crear clientes
        Customer customerUSA = new Customer("John Doe", addressUSA);
        Customer customerCanada = new Customer("Jane Smith", addressCanada);

        // Crear pedidos
        Order orderUSA = new Order(customerUSA);
        Order orderCanada = new Order(customerCanada);

        // Agregar productos a los pedidos
        orderUSA.AddProduct(product1);
        orderUSA.AddProduct(product3);

        orderCanada.AddProduct(product4);
        orderCanada.AddProduct(product2);

        // Mostrar detalles del pedido
        Console.WriteLine("USA Order:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(orderUSA.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(orderUSA.ShippingLabel());
        Console.WriteLine($"Total Price: ${orderUSA.TotalCost()}\n");

        Console.WriteLine("Canada Order:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(orderCanada.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(orderCanada.ShippingLabel());
        Console.WriteLine($"Total Price: ${orderCanada.TotalCost()}\n");
    }
}