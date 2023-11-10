using System;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

class BreathingActivity :ActivityClass
{
   public void GetBreatheActivity()
   {
     GetDuration();  
   DateTime startTime = DateTime.Now;
   DateTime endTime = startTime.AddSeconds(_timeduration);
   DateTime currentTime = DateTime.Now;

   do {
       
      Console.Write("Breathe in...");
      NumberTimerIncrease();
      Console.Write("Breathe out...");
      NumberTimerDecrease();
      Thread.Sleep(1000);
      currentTime = DateTime.Now;

    } while(currentTime < endTime);

   }
}
   
   
  
  
