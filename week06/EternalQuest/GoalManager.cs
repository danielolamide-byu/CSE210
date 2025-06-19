public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (type == "1")
            goal = new SimpleGoal(name, desc, points);
        else if (type == "2")
            goal = new EternalGoal(name, desc, points);
        else if (type == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        if (goal != null)
            _goals.Add(goal);
    }

    public void RecordGoal()
    {
        ListGoals();
        Console.Write("Select goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }

        Console.WriteLine($"Total Score: {_score}");
    }

  public void SaveToFile(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        // Write header row
        writer.WriteLine("GoalType,ShortName,Description,Points");

        // Write each goal as CSV
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }

            // Save score if needed
            Console.WriteLine("");
        writer.WriteLine($"Total Score,{_score}");
    }

    Console.WriteLine($"Goals saved to {filename}");
}

    

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename)) return;

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            Goal goal = type switch
            {
                "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])),
                "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 0, 0),
                _ => null
            };

            goal?.LoadProgress(parts);
            _goals.Add(goal);
        }
    }
}
