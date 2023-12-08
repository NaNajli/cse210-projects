using System.Collections.Generic;
class Cycling :Activity
{
    private double _speed;
     
     public Cycling (string date, int length, double speed ):base(date, length)
    {
       _speed = speed;
    }
    public override double GetSpeed()
    {
      return GetDistance() / GetLength() * 60;
    }
    public override double GetPace()
    {
      return 60 / _speed;
    }
    public override double GetDistance()
    {
      return 0;
    }

    public override void GetSummary()
    {
      Console.WriteLine($"*Cycling: {GetDate()}({GetLength()})Speed {_speed} mph,Pace {GetPace()} per mile.");
    }

    
   
    
     
    
    
}