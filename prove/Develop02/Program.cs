using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
    Console.WriteLine("Welcome to Journal Program!!");
    Console.WriteLine(); 
    Journal journal = new Journal(); 
    PromptGenerator promptGenerator = new PromptGenerator();

    bool quit = false;
    while(!quit)
    {   
        Console.Write("What do you like to do?: ");
        Console.WriteLine();
        Console.WriteLine("Pleace select one of the following choices: ");
        Console.WriteLine("1-Write: ");
        Console.WriteLine("2-Display");
        Console.WriteLine("3-Load");
        Console.WriteLine("4-Save");
        Console.WriteLine("5-Quit"); 
    
      int _entry =  int.Parse(Console.ReadLine());
        if (_entry == 1)
          {
            string _prompt = promptGenerator.RandomPrompt();
            Console.WriteLine(_prompt);
            string answer = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            Entry entry = new Entry(_prompt, answer,date);
            journal.AddEntry(entry);

            }
          else if (_entry == 2)
            {
             journal.Display();
            }

          else if (_entry == 3) 
          {
            Console.WriteLine("Enter the name of the file:");
            string filename = Console.ReadLine();
            journal.SaveFile();

          }
          else if (_entry == 4)
          {
            Console.WriteLine("Enter the name of your file: ");
            string filename = Console.ReadLine();
            journal.LoadFile(filename);
                

          }
          else if (_entry == 5)
            {
              quit = true;
              break;
            }
    
          else {
              Console.WriteLine("Its a error please enter another number");
            }
      }
                          
        
       
    }
}