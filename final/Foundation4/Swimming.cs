class Swimming :Activity
{
  private double _numberLaps;
  public Swimming(string date, int length,double numberLaps):base(date, length)
  {
    _numberLaps = numberLaps; 
  }
  public double SetNumberLaps(double numberLaps)
  {
    return _numberLaps = numberLaps;
  }
  public double GetNumberLaps()
  {
    return _numberLaps;
  }
  public override double GetDistance()
  {
    return _numberLaps * 50 /1000;
  }
  public override double GetSpeed()
  {
    return  GetDistance() / GetLength() * 60;
  }

  public override double GetPace()
  {
       return 60 / GetSpeed();
  }
  public override void GetSummary()
   {
   Console.WriteLine($"*Swimming: {GetDate()}({GetLength() }min)-Distance {GetDistance()}km,Speed {GetSpeed()} mph,Pace {GetPace()} per mile.");
  
   }

   
   
    
}