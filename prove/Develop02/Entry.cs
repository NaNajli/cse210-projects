using System;
public class Entry {
    
    public string Prompt{get;set;}
    public string Answer{get;set;}
    public string Date{get;set;}
    

    public Entry(string date ,string answer,string prompt) 
    {
      Prompt = prompt;
      Answer = answer;
      Date = date;

   }
    public override string ToString()
    {
        return $"{Prompt}  :{Answer}  - {Date}";
    }
}