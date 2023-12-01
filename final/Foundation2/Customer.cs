public class Customer
{
    protected string _name;
     private Address _address;
    
    public Address Address
    {
        get {return _address; }
    }
      public string GetName()
    {
        return _name;
    }
   
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}