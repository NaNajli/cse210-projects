using System;
using System.Formats.Asn1;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Develop04 World!");
   
     bool quit = false;
     while (!quit)
     {
      
      Console.WriteLine("Menu Option:");
      Console.WriteLine("1-Start breathing activity");
      Console.WriteLine("2-Start reflecting activity");
      Console.WriteLine("3-Start listing activity");
      Console.WriteLine("4-Quit");
      Console.WriteLine("5-Surprise");   
      Console.WriteLine("Select a choice from the menu: ");
    
      int answer  =  int.Parse(Console.ReadLine());
      if (answer == 1)
      {
      BreathingActivity breathing  = new BreathingActivity();
      breathing.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing","Breathing Activity");
      breathing.GetStartMessage();
      breathing.GetBreatheActivity();
      breathing.GetMsgEnd();
      
      }
      
      else if (answer == 2)
      {
       ReflectingActivity reflectingActivity = new ReflectingActivity();
       reflectingActivity.SetStartMsg("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life","Reflecting Activity");
       reflectingActivity.GetStartMessage();
       string prompt = reflectingActivity.RandomPrompt();
       Console.WriteLine(prompt);
       Console.WriteLine("when you have something in main,press enter to continue:");
       string input = Console.ReadLine();
       reflectingActivity.Reflection();
       reflectingActivity.GetMsgEnd();
  
          
      }
      else if (answer == 3)
      {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.SetStartMsg("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","Listing Activity");
        listingActivity.GetStartMessage();
        Console.Write("You may begin in: ");
        listingActivity.NumberTimerDecrease();
        listingActivity.InputResponse();
        listingActivity.GetMsgEnd();
     
      }
      else if (answer == 5)
      {
       Surprise surprise = new Surprise(); 
       surprise.SetStartMsg("This activity helps you recognize the really important things in your life.","Surprise Activity");
       surprise.GetStartMessage();
       Console.Write("You may begin in: ");
       surprise.GetSpinner();
       surprise.SurpriseActivity();
       surprise.GetMsgEnd();     
       
      }
      else if (answer == 4)
      {
        quit = true;
        break;
      }
      
      }
      }
     }
