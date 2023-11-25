using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Dynamic;
using System.Formats.Asn1;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
      //  Console.WriteLine("Hello Develop05 World!");
     List <Goal> _goals = new List<Goal>();
     SimpleGoal simpleGoal = new SimpleGoal("Simple","","",0 ,true);
     CheckList checkList = new CheckList("Checklist","","",0,true,0,0,0);
     EternalGoal eternalGoal = new EternalGoal("Eternal","","",0,true);

     bool quit = false;
     while (!quit)
     {
      Console.WriteLine();

      Console.WriteLine($"You have 0 points. ");
      Console.WriteLine("Menu Option:");
      Console.WriteLine("1-Create a New Goal");
      Console.WriteLine("2-List Goals");
      Console.WriteLine("3-Save Goals");
      Console.WriteLine("4-Load Goals");
      Console.WriteLine("5-Record Event");   
      Console.WriteLine("6- Quit");
      Console.Write("Select a choice from the menu: ");
    
      int answer  =  int.Parse(Console.ReadLine());
      if (answer == 1)
      {  
        Console.WriteLine("Which type of goal would you like to create?: ");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1-Simple Goal");
        Console.WriteLine("2-Eternal Goal");
        Console.WriteLine("3-CheckList Goal");
 

         int response =  int.Parse(Console.ReadLine());
         
         if (response == 1)
         {
         
         simpleGoal.CreateGoal();
         _goals.Add(simpleGoal);
        // simpleGoal.SaveFile(_goals);
         
         } 
          
         else if (response == 2)
         {
          
          eternalGoal.CreateGoal(); 
          _goals.Add(eternalGoal);
         // eternalGoal.SaveFile(_goals);
          
          
         }
         else if(response == 3)
         {
        
          checkList.CreateGoal();
          _goals.Add(checkList);
         // checkList.SaveFile(_goals);
         }
      
      }
      else if (answer == 2)
      {
        Console.WriteLine("The goals are: ");
        simpleGoal.ListGoals(_goals);
        eternalGoal.ListGoals(_goals);
        checkList.ListGoals(_goals);
      }

        
      // simpleGoal.ListGoals();
      // checkList.ListGoals();
      // eternalGoal.ListGoals();
      else if (answer == 3)
      {
       simpleGoal.SaveFile(_goals);
      
       
      }
      else if (answer == 4)
      {
       simpleGoal.LoadFile("");
      }
      else if (answer == 5)
      {

      }
      else if (answer == 6)
      {
        quit = true;
        break;
       }
       
      
     
      
     }

         
         

      
}}