using System;

class Program
{
    static void Main(string[] args)
    {
      Address address1 = new Address("65 Rua doutor dimas de barros", "Londrina", "PR", "Brasil");
      Address address2 = new Address("123 Main St","New York", "NY", "USA" );

      Customer customer1 = new Customer("Daniel Américo", address1);
      Customer customer2 = new Customer("Nathan Hanks", address2);

      Product product1 = new Product("Nootbook", "Acer V5", 1300.00, 3);
      Product product2 = new Product("Iphone", "17", 1000.00, 1);

      Order order1 = new Order(customer1);
      order1.AddProduct(product1);

      Order order2 = new Order(customer2);
      order2.AddProduct(product2);

      Console.WriteLine("==== ORDER 1 ====");
      Console.WriteLine(order1.GetPackingLabel());
      Console.WriteLine(order1.GetShippingLabel());
      Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

      Console.WriteLine();

      
      Console.WriteLine("==== ORDER 2 ====");
      Console.WriteLine(order2.GetPackingLabel());
      Console.WriteLine(order2.GetShippingLabel());
      Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }   
}