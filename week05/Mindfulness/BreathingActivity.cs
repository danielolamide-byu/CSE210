
using System.IO;
public class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base("Breathing Activity", "This activity helps relax your mind by helping you breath in and out", duration)
    {

    }
    public void BreathingActivities()
    {
        //DisplayStartingMessageForBreathingActivity();
        //Console.WriteLine("How long in seconds would you like this activity? ");


        Console.Clear();
        Console.WriteLine("Getting ready...");
        ShowSpinnerAnimation();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in    ");
            ShowCountDownAnimation();
            Console.WriteLine("Breath out    ");
            ShowCountDownAnimation();
            Console.WriteLine("");
        }
        DisplayEndingMessage();
        Console.WriteLine($"You have completed another {_duration} seconds the Breathing activity.");
        Console.WriteLine("");
        SaveActivity();
       // Console.WriteLine("Would you like to save your session (yes / no)?  ");
        // string save = Console.ReadLine().ToLower();
        // if (save == "yes")
        // {
        //     SaveActivity();
        //     
        // }
        // else if (save == "no")
        // {
        //
        // }
    }
}
