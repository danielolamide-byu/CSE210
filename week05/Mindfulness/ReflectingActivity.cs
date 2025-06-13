

using System.ComponentModel;
using System.Security.AccessControl;
using System.Xml.Linq;

public class ReflectingActivity : Activity
{
    protected List<string> _reflectionPrompts;
    protected List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> reflectionPrompts, List<string> questions) : base(name, description, duration)
    {
        _reflectionPrompts = reflectionPrompts;
        _questions = questions;
    }
    //public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)


    public void ReflectionActivity()
    {
        Console.Write("How  long in seconds would you like to do this activity? ");
        string _duration = Console.ReadLine();
        int duration = int.Parse(_duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(5000);
        //Animation.
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompts:");
        Console.WriteLine("");
        DisplayRandomPrompt();
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter...");
        string _enter = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Now ponder on the following questions as they relate to you. \nYou may begin in ");
        Thread.Sleep(5000);
        Console.Clear();
     }

    public string GetRandomPrompt()
    {
        Random _randomGeneratorForPrompt = new Random();
        int _randPrompt = _randomGeneratorForPrompt.Next(_reflectionPrompts.Count);
        string _selectedPrompt = _reflectionPrompts[_randPrompt];
        return _selectedPrompt;
    }

    public string GetRandomQuestion(int durationInSeconds)
    {
        Random _randomGeneratorForQuestions = new Random();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime && _questions.Count > 0)
        {
            int _randomQuestion = _randomGeneratorForQuestions.Next(_questions.Count);
            string _selectedQuestion = _questions[_randomQuestion];
            _questions.RemoveAt(_randomQuestion);        //Avoid asking the same question more than once.
        }
        return string.Join("\n", _questions);
         }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayRandomQuestion()
    {
        int durationInSeconds = 30;
        Console.WriteLine($"{GetRandomQuestion(durationInSeconds)}");
    }


    public void Run()
    {
        ReflectionActivity();
         DisplayRandomQuestion();

        
    }

}