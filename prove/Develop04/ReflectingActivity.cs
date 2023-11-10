using System;
class ReflectingActivity :ActivityClass
{
  protected List<string>_prompt;

  public ReflectingActivity()
  {
     _prompt = new List<string>

    {
    "---Think of a time when you stood up for someone else.---",
    "---Think of a time when you did something really difficult.---",
    "---Think of a time when you helped someone in need.---",
    "---Think of a time when you did something truly selfless.---",

    };
  }
 
    public string RandomPrompt()
    {
    Console.WriteLine("Consider de following prompt: ");    
    Random random = new Random();
    int index = random.Next(_prompt.Count);
    return _prompt[index];
   }

   public void Reflection()
   {
    
    GetDuration();  
    //TimerReflection();

    DateTime start= DateTime.Now;
    DateTime end = start.AddSeconds(_timeduration);
    DateTime currentTime = DateTime.Now;
   
   do {
       
       Console.WriteLine("Why was this experience meaningful to you?");
       Thread.Sleep(3000);
       Console.WriteLine("Have you ever done anything like this before?");
       Thread.Sleep(3000);
       Console.WriteLine("How did you get started?");
       Thread.Sleep(3000);
       Console.WriteLine("How did you feel when it was complete?");
       Thread.Sleep(3000);
       Console.WriteLine("What made this time different than other times when you were not as successful?");
       Thread.Sleep(3000);
       Console.WriteLine("What is your favorite thing about this experience?");
       Thread.Sleep(3000);
       Console.WriteLine("What could you learn from this experience that applies to other situations?");
       Thread.Sleep(3000);
       Console.WriteLine("What did you learn about yourself through this experience?");
       Thread.Sleep(3000);
       Console.WriteLine("How can you keep this experience in mind in the future?");
       Thread.Sleep(3000);
       
       currentTime = DateTime.Now;
      
      } while(currentTime < end);
        

        
      
   }

   public void TimerReflection()
   {
     Console.Write("You may begin in:");
     NumberTimerDecrease();

   }
}