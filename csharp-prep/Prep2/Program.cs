using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        
        Console.Write("What is you grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        string letter = ""; 
         
        if ( x >= a)
        {   letter = "A";
           // Console.WriteLine($"Your grade is {letter}");
            }
           
       else if ( x >= b )
       {   letter = "B";
          // Console.WriteLine("Your grade is B");
       }
       else if ( x >= c )
       {   letter = "C";
          // Console.WriteLine("Your grade is C");
       }
       else if ( x >= d )
       {   letter = "D";
           //Console.WriteLine("Your grade is D");
       }
       else if ( x < d )
       {   letter = "F";
          //Console.WriteLine("Your grade is F");
       }

       Console.WriteLine($"Your grade is {letter}");

       if (x >= c)
       {
           Console.WriteLine("Congratulations, you passed the course!!");
       }
        else if (x < c)
       {
           Console.WriteLine("Sorry, you didn't pass the course, keep trying.!!");
       }



        
        


        


         
    }
}