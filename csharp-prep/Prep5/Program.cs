using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(UserNumber);

        DisplayResult( UserName, squaredNumber);
    
  
       //Displays the message, "Welcome to the Program!"
       static void DisplayWelcome()
       {
        Console.WriteLine("Welcome to the Program!");
       }
       //Asks for and returns the user's name (as a string)
       static string PromptUserName()
       {
          Console.Write("Please enter your name: ");
          string name = Console.ReadLine();
          return name;
          
       }
       //Asks for and returns the user's favorite number (as an integer)
       static int PromptUserNumber()
       {
        Console.Write("Please enter your favorite number: ");
         int Fnumber = int.Parse(Console.ReadLine());
         return Fnumber;
       }
       // Accepts an integer as a parameter and returns that number squared (as an integer)

       static int SquareNumber (int Fnumber)

        { int square = Fnumber * Fnumber;
          return square;
        }
       //Accepts the user's name and the squared number and displays them.
       static void DisplayResult(string name, int square)
       {
        Console.WriteLine($"{name}, the square of your number is {square}");
       }
    }
    }   