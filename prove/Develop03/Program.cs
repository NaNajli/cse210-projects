using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
       
       Reference reference = new Reference(" Proverbs","3 5-6");
       string text = " Trust in the Lord with all thine heart and lean not unto thine own understanding "; 
      
       Scripture scripture = new Scripture( reference,text);

        scripture.ShowScripture();

       Console.WriteLine();
       Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
       string answer = Console.ReadLine();
    
       while ( answer!= "quit")
       {
        scripture.HideWords();
        scripture.ShowScripture();

            if (scripture.AllWordsHidden())
            {
              break;
            }

            answer = Console.ReadLine();    
       }

    }
}
           