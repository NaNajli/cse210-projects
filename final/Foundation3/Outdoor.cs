public class Outdoor : Event
{
  private string _statement;
      public Outdoor(string title, string description,string date, int time,Address address,string statement):base(title, description,date,time,address)
    {
      _statement = statement;
    }
     public void GetDetailOutdoor()
    {
      Console.WriteLine($"Weather:{_statement}");
    }
    

}