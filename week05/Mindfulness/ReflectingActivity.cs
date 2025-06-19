

using System.ComponentModel;
using System.Security.AccessControl;
using System.Xml.Linq;
using System.IO;

public class ReflectingActivity : Activity
{
    protected List<string> _reflectionPrompts;
//    protected List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> reflectionPrompts, List<string> questions) : base(name, description, duration)
    {
        _reflectionPrompts = reflectionPrompts;
       // _questions = questions;
    }
    
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
    //public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)


    public void ReflectionActivity()
    {
        Console.WriteLine("Get ready...");
        //Thread.Sleep(5000);
        ShowSpinnerAnimation();
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompts:");
        Console.WriteLine("");
        DisplayRandomPrompt();
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter...");
        string _enter = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on the following questions as they relate to you. \nYou may begin in ");
        ShowCountDownAnimation();
        //Thread.Sleep(5000);
        Console.Clear();
        GetRandomQuestions(_duration);
        Console.WriteLine("");
        DisplayEndingMessage();
        Console.WriteLine($"You have completed {_duration} seconds of the Reflecting Activity!");
        SaveActivity();
    }

    public string GetRandomPrompt()
    {
        Random _randomGeneratorForPrompt = new Random();
        int _randPrompt = _randomGeneratorForPrompt.Next(_reflectionPrompts.Count);
        string _selectedPrompt = _reflectionPrompts[_randPrompt];
        return _selectedPrompt;
    }



    public string GetRandomQuestions(int duration)
    {
        Random random = new Random();
        List<string> askedQuestions = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime && _questions.Count > 0)
        {
            int index = random.Next(_questions.Count);
            string selectedQuestion = _questions[index];

            askedQuestions.Add(selectedQuestion);
            _questions.RemoveAt(index);

            Console.WriteLine(selectedQuestion);
            ShowSpinnerAnimation();
            Thread.Sleep(1000);
        }
        return string.Join("\n", "0");
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayRandomQuestion()
    {
        int durationInSeconds = _duration;
        Console.WriteLine($"{GetRandomQuestions(durationInSeconds)}");
    }
    public void Run()
    {
        ReflectionActivity();
        //DisplayRandomQuestion();
     }

}