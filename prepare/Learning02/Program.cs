using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._company= "360 Logistics LLC";
        job1._jobTitle= "Delivery Driver";
        job1._startYear= 2023;
        job1._endYear= 2023;
        // job1.Display();

        Job job2= new Job();
        job2._company= "Ironwood Insights Group";
        job2._jobTitle= "Interviewer";
        job2._startYear= 2023;   
        job2._endYear= 2023;
        // job2.Display();

        Resume myResume= new Resume();
        myResume._name= "Keith Crawford";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.DisplayResume();
    }
}