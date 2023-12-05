public class Receptions:Event
{
  private string _mail;
      public Receptions(string title, string description, string date, int time, Address address, string mail):base(title, description, date,time,address)
    {
      _mail = mail;
    
    }
    public void GetDetailReceptions()
    {
      Console.WriteLine($"Email for RSVP: {_mail}");
    }
    

    
}