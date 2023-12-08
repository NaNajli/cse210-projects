using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Running: Activity
{
     private double _distance;
   
     public Running(string date, int length,double distance):base( date,length)
     {
        _distance = distance;
     }
     public override double GetDistance()
     {
       return _distance;
     }
     
     public override double GetSpeed()
     {
      return  _distance / GetLength() * 60;
     }
     public override double GetPace()
    {
      return GetLength()/ _distance;
    }
    public override void GetSummary()
    {
      Console.WriteLine($"*Running: {GetDate()}({GetLength() }min)-Distance {_distance}km,Speed {GetSpeed()} mph,Pace {GetPace()} per mile.");
    }





}