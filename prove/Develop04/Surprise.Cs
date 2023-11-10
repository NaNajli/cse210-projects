class Surprise : ActivityClass
{

public void SurpriseActivity()
{
   GetDuration(); 
   DateTime currentTime = DateTime.Now;
   DateTime startTime = DateTime.Now;
   DateTime endTime = startTime.AddSeconds(_timeduration);
  
   Console.WriteLine("");
   Console.WriteLine(" POSITIVE MIND AND STAND UP IN.."); 
   NumberTimerDecrease();
   Console.WriteLine("Look outside or any nice place..");
   Console.WriteLine();
   Console.WriteLine("Take some time to think about what you are grateful for.");
    NumberTimerDecrease();
   do {
     Console.WriteLine("I am grateful for...");
     GetSpinner();
     currentTime = DateTime.Now;

    } while(currentTime < endTime);
     Console.WriteLine("DON'T FORGET TO SMILE TODAY");
}
}