using System;
class Program
{
    static void Main(string[] args)
    {

    Job job1 = new Job();

    job1._jobTitle = "software engineer";
    job1._company = "Microsft";
    job1._startYear = "1970";
    job1._endYear = "2001";

    Job job2 = new Job();

    job2._jobTitle = "coffee boy";
    job2._company = "Apple";
    job2._startYear = "2003";
    job2._endYear = "2005";


    Resume myResume = new Resume();
    
    myResume._name = "Anderson Packer";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();
    }
}
