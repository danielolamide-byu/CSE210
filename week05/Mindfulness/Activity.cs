

using System.Text;
using System.IO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    //  public Activity()
    //  {
    //      
    //  }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }



    public void Activities()
    {
        Console.WriteLine("Menu Options:");
        Console.Write(" 1. Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \nSelect a choice from the menu(1-3): ");
        //string input = Console.ReadLine();
    }

    //public void Runner()
    //   {
    //  Rune()
    //}
    // Undo public void DisplayStartingMessage()

    public void DisplayStartingMessageForBreathingActivity()
    {
        Console.WriteLine("\nWelcome to the Breathiing Activity! \n\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void DisplayStartingMessageForListingActivity()

    {
        Console.WriteLine("\nWelcome to the Listing Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
    }

    public void DisplayStartingMessageForReflectingActivity()

    {
        Console.WriteLine("\nWelcome to the Reflecting Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Welldone");
    }

    public void ShowSpinnerAnimation()
    {
        List<string> animation = new List<string>();
        {
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
        }

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void ShowCountDownAnimation()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void SaveActivity()
    {
        Console.Write("Would you like to save your session (yes / no)?  ");
        string save = Console.ReadLine().ToLower();
        string filename = "ActivityFile.txt";
      if (save == "yes")

            using (StreamWriter outputFile = new StreamWriter(filename, append : true))
            {
                if (_name == "Breathing Activity")
                {

                    {
                        outputFile.WriteLine($"You completed {_duration} seconds of the Breathing Activity");
                        Console.WriteLine($"Activity saved to {filename}");
                    }

                }
                else if (_name == "Reflecting Activity")
                {
                    outputFile.WriteLine($"You completed {_duration} seconds of the Reflecting Activity");
                    Console.WriteLine($"Activity saved to {filename}");
                }
                else if (_name == "Listing Activity")
                {
                    outputFile.WriteLine($"You completed {_duration} seconds of the Listing Activity");
                    Console.WriteLine($"Activity saved to {filename}");
                }
                else if (save == "no")
                {
                    Console.WriteLine("You did not save this session!");

                }
                else
                {
                    Console.WriteLine("Choose a correct option!");
                }
            }
             
        
        
          
    //public void SaveActivity()
            //{
            //    Console.Write("Would you like to save your session (yes / no)?  ");
            //    string save = Console.ReadLine().ToLower();
            //    if (save == "yes" && _name == "Breathing Activity")
            //    {
            //        string filename = "ActivityFile.txt";
            //
            //        using (StreamWriter outputFile = new StreamWriter(filename))
            //        {
            //            outputFile.WriteLine($"You completed {_duration} seconds of the Breathing Activity");
            //
            //            Console.WriteLine($"Activity saved to {filename}");
            //        }
            //    }
            //    else if (save == "yes" && _name == "Reflecting Activity")
            //    {
            //        string filename = "ActivityFile.txt";
            //        using (StreamWriter outputFile = new StreamWriter(filename))
            //            outputFile.WriteLine($"You completed {_duration} seconds of the Reflecting Activity");
            //        Console.WriteLine($"Activity saved to {filename}");
            //    }
            //    else if (save == "yes" && _name == "Listing Activity")
            //    {
            //        string filename = "ActivityFile.txt";
            //        using (StreamWriter outputFile = new StreamWriter(filename))
            //            outputFile.WriteLine($"You completed {_duration} seconds of the Listing Activity");
            //        Console.WriteLine($"Activity saved to {filename}");
            //    }
            //    else if (save == "no")
            //    {
            //        Console.WriteLine("You did not save this session!");
            //
            //    }
            //    else
            //    {
            //        Console.WriteLine("Choose a correct option!");
            //    }
            //         

            // You can add text to the file with the WriteLine method
            // if (_name == "Listing Activity")
            // {
            //     outputFile.WriteLine($"You completed {_duration} of the Listing Activity.");
            // }
            // else if (_name == "Breathing Activity")
            // {
            //     outputFile.WriteLine($"You completed {_duration} seconds of the Breathing Activity");
            // }

            // You can use the $ and include variables just like with Console.WriteLine
            //      string color = "Blue";
            //  outputFile.WriteLine($"My favorite color is {color}");
        }
    }
 