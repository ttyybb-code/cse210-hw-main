using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();
        job1._company = "microsoft";
        job1._jobTitle = "software engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._company = "apple";
        job2._endYear = 2018;
        job2._jobTitle = "marketing";
        job2._startYear = 2010;
        resume._name = "Andrew";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Show();
    }
}
