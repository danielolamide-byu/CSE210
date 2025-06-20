using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you reflect on good things in your life.")
    {
    }

    public void ListingActivities()
    {
        Console.Write("Enter the duration in seconds: ");
        string time = Console.ReadLine();
        int times = int.Parse(time);

        Console.Clear();
        Console.WriteLine("Getting ready...");
        Thread.Sleep(2000);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("You may begin in:");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Start listing responses (press Enter after each):");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(times);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You entered {_count} items.");
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[randIndex];
    }

    public void Run()
    {
        ListingActivities();
    }
}
