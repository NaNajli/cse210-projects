class EternalGoal :Goal
{
    public EternalGoal(string type, string name, string description, int point, bool completed):base(type,name,description,point)
    {
     
    }
    public override void CreateGoal()
  {  
      Console.Write("What is the name of your goal? ");
      _name = Console.ReadLine();
      Console.Write("What is a short description of it? ");
     _description = Console.ReadLine();
      Console.Write("What is the amount of point associated with this goal? ");
     _point = int.Parse(Console.ReadLine());        
           
  }
   public override void ListGoals(List<Goal>_goals)
     {
  
       Console.WriteLine($"[] {_name}({_description})");
      
     }
     public  override string GetStringRepresentation()
     {
       
       return $"{_type}:{_name},{_description},";
     }
      public override int RecordEvent()
    {
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
}}