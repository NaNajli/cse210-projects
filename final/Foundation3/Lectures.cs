public class Lectures:Event
{
    private string _name;
    private int _capacity;

 
    public Lectures(string title, string description, string date, int time, Address address,string name,int capacity):base(title, description, date,time ,address)
    {
      _capacity = capacity;
      _name = name;
    }

    public void GetDetailLecture()
    {
      Console.WriteLine($"Speaker:{_name} the place have a capacity of {_capacity} people.");
    }

}

