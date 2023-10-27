using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Learning04 World!");
       Console.WriteLine();
       Assignment assignment = new Assignment("Samuel Bennett","Multiplication");
       Console.WriteLine(assignment.GetSummary());
       
       
       MathAssignment assignment2 = new MathAssignment("Section", "7.3","Problems", "8-19");
       Console.Write(assignment2.GetHomeworkList());
       Console.WriteLine(assignment2.GetSummary());
       
       WritingAssignment assignment3 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
       Console.Write(assignment3.GetStudentName());
       Console.WriteLine(assignment3.GetTopic());
       Console.WriteLine(assignment3.GetWritingInformation());
       Console.WriteLine();
    }
}