using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //new instance of Job class
        Job job1 = new Job();

        //defines members of job1
        job1._jobTitle = "Santition Engineer";
        job1._company = "Western Metals";
        job1._startYear = 2012;
        job1._endYear = 2018;

        //blank line to make output easier to read
        Console.WriteLine();

        //new instance of Job class
        Job job2 = new Job();

        //defines memebers of job2
        job2._jobTitle = "Police Officer";
        job2._company = "LAPD";
        job2._startYear = 2018;
        job2._endYear = 2023;

        //new instance of Remume class
        Resume resume1 = new Resume();

        //adds instances of Job class into _jobs list in Resume class
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        //defines member of resume1
        resume1._name = "Mitchel Hunter";

        //output
        resume1.DisplayJobs();
        //blank line to make output easier to read in terminal
        Console.WriteLine();


    }
}