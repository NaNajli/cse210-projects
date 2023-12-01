using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

public class Order
{
    public List <Product> _product; 
    private Customer _customer;

    public Order(Customer customer)
    {
      _customer = customer;
      _product = new List<Product>();
    }
    
    public void  GetPackingLabel()
    {
     foreach (Product product  in _product)
     {
      Console.WriteLine($"Product: {product.GetNameProduct()} ID:{product.GetId()} Quantity:{product.GetQuantity()} Price:${product.GetPrice()}");
     }
    } 
    public void GetShippingLabel()
    {
     Console.WriteLine($"Name: {_customer.GetName()} Address:{_customer.Address.GetAddress()} ");
    } 
    public void GetShippingCost()
    {
      foreach (Product product in _product)
      {  
        int total = product.GetPrice() * product.GetQuantity();

        if (_customer.Address.GetCountryUsa())
        {
        int totalusa = total + 5;
        Console.WriteLine($"Total price of the order:$ {totalusa}");
        }
        else
        {
        int totalnotusa = total + 35;
        Console.WriteLine($"Total price of the order:$ {totalnotusa}");
        }
      } 
    }
    public void AddProducts(Product product)
    {
      _product.Add(product);
    }
}
    

 
