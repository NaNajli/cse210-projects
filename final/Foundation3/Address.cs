using System.Dynamic;
using System.Runtime.InteropServices;

public class Address
{
   private string _street;
   private string _city;  

   public Address(string city , string street)
   {
     _city = city;
     _street = street;
   }
 
    public string GetAddress()
    {
     return $"Address:{_city}-{_street}";
     
    }
    
    
}