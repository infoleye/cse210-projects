using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Chattered Accountant";
        job1._company = "Infoleye";
        job1._startYear = 2020;
        job1._endYear = 2026;

        Job job2 = new Job();

        job2._jobTitle = "Head of Finance";
        job2._company = "Killimanjaro";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume myResume = new Resume();

        myResume._name = "Young John";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}