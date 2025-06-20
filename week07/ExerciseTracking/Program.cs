using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

         List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 05, 3), 30, 4.8),
            new Cycling(new DateTime(2025, 05, 3), 45, 15.0),
            new Swimming(new DateTime(2025, 05, 3), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}