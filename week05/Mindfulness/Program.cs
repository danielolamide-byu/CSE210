using System;
using System.Xml.Serialization;

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

        ReflectingActivity reflect = new ReflectingActivity("Rreflecting Activity", "Helps you get better", 13, _reflectionPrompts, _questions);


        ListingActivity list = new ListingActivity();
        

                reflect.Activities();

        string _choice = Console.ReadLine();
        if (_choice == "1")
        {

        }
        else if (_choice == "2")
        {
            //reflect.DisplayStartingMessage();
            reflect.ReflectionActivity();
            reflect.DisplayRandomQuestion();
        }
        else if (_choice == "3")
        {
            list.Run();
            Console.WriteLine("");
            list. DisplayEndingMessage();
         }



       // act.ShowSpinnerAnimation();








    }
}