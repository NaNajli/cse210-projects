using System;

class ListingActivity :ActivityClass
{
    protected List<string>_listingPrompt;

    
    public ListingActivity()
    {
  
     _listingPrompt = new List<string>

    {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes?",

    };
    }
  
   public string RandomListingPrompt()
   {
  
   Console.WriteLine("Consider de following prompt: "); 
   Random random = new Random();
   int index = random.Next(_listingPrompt.Count);
   return _listingPrompt[index];

      
   }

  public void InputResponse()
  {
        GetDuration();  
   DateTime startTime = DateTime.Now;
   DateTime endTime = startTime.AddSeconds(_timeduration);
   DateTime currentTime = DateTime.Now;

   do {

    string promptlisting = RandomListingPrompt();
    Console.WriteLine(promptlisting);
    string  inputResponse = Console.ReadLine();
  
   }while (DateTime.Now < endTime);
    
  
}}