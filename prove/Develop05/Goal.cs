using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

abstract class  Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _point;

    public Goal(string type, string name, string description, int point)
    {
      _type = type;
      _name = name;
      _description = description;
      _point = point;
   

    }
     public int GetPoint()
     {
      return _point;
     }
       public void SetPoint(int point)
       {
           _point = point;
       }

       public void SetName(string name)
       {
        _name = name;
       }
       public string GetName()
       {
        return _name;
       }
       public virtual void CreateGoal()
       {
       }   
       public abstract void ListGoals(List<Goal>_goals);

      public abstract string GetStringRepresentation();
      public abstract int RecordEvent();
      public abstract bool IsComplete();

      

     // public abstract bool IsCompleted();
      
     public abstract void LoadFile(string filename);

    
       
      public void SaveFile(List<Goal>_goals)
     {
       Console.Write("Whats is the filename for the goal file?");
       string filename = Console.ReadLine();
       using (StreamWriter outputFile = new StreamWriter(filename))
       
        foreach (Goal line in _goals)
        {
        outputFile.WriteLine( line.GetStringRepresentation());
         }
        
}}