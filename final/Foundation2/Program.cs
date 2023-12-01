using System;

class Program
{
    static void Main(string[] args)
    {
      
      
      // Console.WriteLine("Hello Foundation2 World!");
      Product product1 = new Product("Skirt",345,4,50);
      Product product2 = new Product("Pants", 234,3,45);
      Product product3 = new Product("Jeans", 29, 10, 170);

      Address address1 = new Address("Roads 23", "Orem", "Utah", "USA");
      Address address2 = new Address("Street 256", "Huron", "Dakota", "USA");  
      Address address3 = new Address("Saldan 234", "Carlos Paz", "Cordoba", "Argentina");  
      
      Customer customer1 = new Customer("Peter Simon ", address1);
      Customer customer2 = new Customer("Susan Smith", address2);  
      Customer customer3 = new Customer("Nasha Quimono", address3);  

      Order order1 = new Order(customer1);
      order1.AddProducts(product1);
      Order order2 = new Order(customer2);
      order2.AddProducts(product2);
      Order order3 = new Order(customer3);
      order3.AddProducts(product3);
     
      Console.WriteLine("The Order:");
      Console.WriteLine("Order 1");
      order1.GetShippingLabel();
      order1.GetPackingLabel();
      order1.GetShippingCost();

      Console.WriteLine("The Order:");
      Console.WriteLine("Order 2");
      order2.GetShippingLabel();
      order2.GetPackingLabel();
      order2.GetShippingCost();

      Console.WriteLine("The Order:");
      Console.WriteLine("Order 3");
      order3.GetShippingLabel();
      order3.GetPackingLabel();
      order3.GetShippingCost();
     
    }
}
