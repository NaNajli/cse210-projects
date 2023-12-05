using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private int _time;
    private Address _address;

    public Event(string title, string description, string date, int time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }
    public Address Address
    {
        get {return _address; }
    }
    public void GetStandardDetails()
    {
        Console.WriteLine($"Event: {_title}. {_description} Date:{_date}, Time:{_time}pm ,{Address.GetAddress()}");  
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{_title} on {_date}");   
    }
    

} 