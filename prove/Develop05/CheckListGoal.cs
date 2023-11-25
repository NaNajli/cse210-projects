using System.Collections.Generic;
class CheckList:Goal
{
    protected int _bonusPoint;
    protected int _totalrepetition;
    protected int _numberRepetition;
    

    public CheckList(string type, string name, string description, int point, bool completed, int bonusPoint,int totalrepetition,int numberRepetition):base(type,name,description,point)
{
 int _bonusPoint = bonusPoint;
 int _totalrepetition = totalrepetition;
 int _numberRepetition = numberRepetition;
}
   public override void CreateGoal()
  {
           
       Console.Write("What is the name of your goal? ");
       _name = Console.ReadLine();
       Console.Write("What is a short description of it? ");
       _description = Console.ReadLine();
       Console.Write("What is the amount of point associated with this goal? ");
       _point = int.Parse(Console.ReadLine()); 
       Console.Write("How many times does this goal need to be accomplished for a bonus? ");   
       _numberRepetition = int.Parse(Console.ReadLine());   
       Console.Write("What is the bonus for acomplishing it that many times? "); 
       _bonusPoint = int.Parse(Console.ReadLine());  
           
  }
   public override void ListGoals(List<Goal>_goals)
     {
   
      
       Console.WriteLine($"[] {_name}({_description})");
      
     }
     public  override string GetStringRepresentation()
     {
        return $"{_type}:{_name},{_description},{_point},{_numberRepetition},{_bonusPoint}";
     }
      public override int RecordEvent()
    {
      //bool _completed = true;
      return GetPoint();

    }
    
    public override bool IsComplete()
    {
        return false;
    }
    public override void LoadFile(string filename)
      {
        Console.Write("Whats is the filename for the goal file?");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
      
         foreach (string line in lines)
        {
         string[] parts = line.Split("--");
     
         _type = parts[0];
         _name = parts[1];
         _description = parts[2];
         _point = int.Parse(parts[3]);
        
        
        }
    }
}
 
