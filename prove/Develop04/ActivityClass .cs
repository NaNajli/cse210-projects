using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class ActivityClass{
 private string _startMsg = "";
 private string _activity = "";
 protected int _timeduration;
 
 private string _end = "";
 List <string> AnimationStrings = new List<string>();
 private string _spinner;

 public string _time = "";


public string GetStartMsg()
{
   return $"{_startMsg} by {_activity} ";
  
}
public void SetStartMsg(string startMsg , string activity)
{
_startMsg = startMsg;
_activity = activity;
}
public void GetStartMessage()
{
Console.WriteLine($"Welcome to the {_activity}");
Console.WriteLine();
Console.WriteLine($"{_startMsg}");
Console.WriteLine("");

}
public string SetMsgEnd(string end)
{
   return _end = end;
}
public void GetMsgEnd()
{
 GetSpinner();
 Console.WriteLine();
 Console.WriteLine("Well Done!!");
 Console.WriteLine( $"You have completed another {_time} seconds of the {_activity} ");
 GetSpinner();
}

   public void NumberTimerIncrease()
    {
      Console.WriteLine("");
      for (int i= 3 ; i> 0 ;i--)
      {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
      }
    }
     public void NumberTimerDecrease()
    {
      Console.WriteLine("");
      for (int i= 6 ; i> 0 ;i--)
      {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
      }}
      public void GetSpinner()
      {  
         
        AnimationStrings.Add("|");
        AnimationStrings.Add("/");
        AnimationStrings.Add("-");
        AnimationStrings.Add("|");
       
        foreach(string s in AnimationStrings)
        {
          Console.Write(s);
          Thread.Sleep(1000);
          Console.Write("\b \b");
        }
      }

public void  GetDuration()
{ 

  Console.Write("How long, in second, would you like for this seccion? ");
  Console.WriteLine();
  _time = Console.ReadLine();
  _timeduration = int.Parse(_time);

  if ( _timeduration > 0)
  {

   Console.WriteLine("Get Ready...");
   GetSpinner();
  // Thread.Sleep(_timeduration);
   //Console.Write("\b \b"); 
 
   }  

}}

      
     
    
   


