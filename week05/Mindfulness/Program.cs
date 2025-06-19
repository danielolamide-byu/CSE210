

// I showed creativity by asking the the user if they wanted to save their session. And if they enter 'yes', the session is saved in an 'ActivityFile.txt' file.
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        List<string> _reflectionPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.?"
    };
        List<string> _questions = new List<string>()
     {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
};

        Activity act = new Activity("hfh", "hdh", 40);
        act.Activities();
        string _choice = Console.ReadLine();

        // ReflectingActivity reflect = new ReflectingActivity("Rreflecting Activity", "Helps you get better", 13, _reflectionPrompts, _questions);
        //reflect.Activities();

        if (_choice == "1")
        {
            act.DisplayStartingMessageForBreathingActivity();
            Console.Write("\nEnter the duration you want to do this activity for in seconds: ");
            string times = Console.ReadLine();
            int duration = int.Parse(times);
            BreathingActivity breath = new BreathingActivity(duration);
            breath.BreathingActivities();
        }

        else if (_choice == "2")
        {
            act.DisplayStartingMessageForReflectingActivity();
            //reflect.ReflectionActivity();
            Console.Write("Enter the duration in seconds: ");
            string times = Console.ReadLine();
            int durations = int.Parse(times);
            ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "Helps you get better", durations, _reflectionPrompts, _questions);
            reflect.Run();
        }

        else if (_choice == "3")
        {
            act.DisplayStartingMessageForListingActivity();
            Console.Write("Enter the duration in seconds: ");
            string time = Console.ReadLine();
            int duration = int.Parse(time);
            ListingActivity list = new ListingActivity(duration);
            list.Rune();
        }



        // act.ShowSpinnerAnimation();
    }
};