 abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
      _date = date;
      _length = length;
    }
    
    public string SetDate(string date)
    {
      return _date = date;
    }
    public string GetDate()
    {
      return _date;
    }
   
     public double GetLength()
    {
      return _length;
    }
    public int SetLength(int length)
    {
      return _length = length;
    }
    public abstract double GetSpeed();
   
    public abstract double GetDistance();

    public abstract double GetPace();
  
    public abstract void GetSummary();
     
}