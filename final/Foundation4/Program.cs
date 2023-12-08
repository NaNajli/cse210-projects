using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Foundation4 World!");
       Console.WriteLine();
        List<Activity>activity = new List<Activity>();
        
        Cycling cycling = new Cycling("Oct 30",30,70);
        Running running = new Running("Sep 2", 50,300);
        Swimming swimming = new Swimming("Feb 21", 30, 100);
       
        activity.Add(cycling);
        activity.Add(running);
        activity.Add(swimming);

        foreach (Activity  a in activity)
        {
         a.GetSummary();
        }
        Console.WriteLine();

    }
}