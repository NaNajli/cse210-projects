using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Tester";
        job1._company = "BlueIt";
        job1._startYear = 2009;
        job1._endYear = 2021;


        Job job2 = new Job();
        job2._jobTitle = "software Ingeniera";
        job2._company = "Team";
        job2._startYear = 2021;
        job2._endYear = 2023;



        Resume resume = new Resume();
        resume._name = "Nadia Rodriguez";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

        

    }
}