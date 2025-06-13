

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

    }
    // Undo public void DisplayStartingMessage()


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
            Console.Write("\b\b");
        }
    }
}