using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("Hello Prep4 World!");

      List<int> Lnumbers = new List<int>(); 

      Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
      
      int numb = -1;
      int i = 0;
      while (numb != i)
      {
      Console.Write("Enter number: ");
      string numbers = Console.ReadLine();
      numb = int.Parse(numbers);
       
       if(numb !=i)
        {
          Lnumbers.Add(numb);   
        }
      }
      
      int sum = 0;
      float average = 0;
      foreach (int number in Lnumbers)
       {
        sum =Lnumbers.Sum();
        average = ((float)sum)/Lnumbers.Count;
       }
       Console.WriteLine($"The sum is: {sum}"); 
       Console.WriteLine($"The average is: {average}"); 
      

      foreach (int number in Lnumbers)
      {
          if (number > i)
          {
            i = number;
          }
      }
      Console.WriteLine($"The max is: {i}");
    }
           
     }