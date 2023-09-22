using System;

class Program
{
    static void Main(string[] args)
    {
   
      Random randomGenerator = new Random();
      int guess = randomGenerator.Next(1,101);
       
      int magic = -1;
      
      while (guess != magic) 
        { 
          Console.Write(" What is the magic number?");
          string magicNumber = Console.ReadLine();
          magic = int.Parse(magicNumber);  
         
           if (guess < magic)
           {
             Console.WriteLine("Lower");
           }
           else if (guess > magic)
           {
             Console.WriteLine("Higher");
           }
           else 
           {
             Console.WriteLine("You guessed it!");       
           } 
          
            
        }
    }}
           
        
       
      

      

      
   
       
    
