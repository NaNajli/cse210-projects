public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private int _price;
    private int _quantity;


     public Product(string nameProduct, int id, int quantity, int price)
    {
        _nameProduct = nameProduct;
        _idProduct = id;
        _quantity = quantity;
        _price = price;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }
    public string SetName(string nameProduct)
    {
        return _nameProduct = nameProduct;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int SetPrice(int price)
    {
      return _price = price;
    }
    public int GetId()
    {
        return _idProduct;
    }
    public int SetId(int idProduct)
    {
       return _idProduct = idProduct;
    }
    public int SetQuantity(int quantity)
    {
     return _quantity = quantity;
    }
    public int GetQuantity()
    {
      return _quantity;
    }
}