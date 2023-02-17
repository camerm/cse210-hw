using System;

class Program
{
    static void Main(string[] args)
    {
        Customer Oliverio = new Customer("Tom", new Address("av salaverry 308", "Huaranguillo", "Arequipa", "PEru"));
        Order OliverioOrder = new Order(Oliverio);
        Product p1 = new Product("Apple", "4657", 25, 2);
        Product p2 = new Product("BAnana", "2067", 30, 1);
        OliverioOrder.AddProduct(p1);
        OliverioOrder.AddProduct(p2);
        
        Customer Laura = new Customer("Bob", new Address("av sant George 507", "Fayette", "Nueva York", "USA"));
        Order LauraOrder = new Order(Laura);
        Product p4 = new Product("shoes", "2234", 50, 1);
        Product p5 = new Product("dress", "4635", 55, 1);
        LauraOrder.AddProduct(p4);
        LauraOrder.AddProduct(p5);
        Console.WriteLine();        
        Console.WriteLine();


        Console.WriteLine(" Order N°1: Oliverio");
        Console.WriteLine(OliverioOrder.PackingLabel());           
        Console.WriteLine(OliverioOrder.ShippingLabel());
        Console.WriteLine("Total Price: {0:C}", OliverioOrder.TotalPrice());
        Console.WriteLine();        

        Console.WriteLine(" Order N°2: Laura");
        Console.WriteLine(LauraOrder.PackingLabel());             
        Console.WriteLine(LauraOrder.ShippingLabel());       
        Console.WriteLine("Total Price: {0:C}", LauraOrder.TotalPrice());

    }
}