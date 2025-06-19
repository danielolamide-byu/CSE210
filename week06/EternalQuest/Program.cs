using System;


// I showed creativity by saving the file as CSV.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal\n2. Record Event\n3. List Goals\n4. Save\n5. Load\n6. Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.RecordGoal(); break;
                case "3": manager.ListGoals(); break;
                case "4":
                    Console.Write("Filename: ");
                    manager.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Filename: ");
                    manager.LoadFromFile(Console.ReadLine());
                    break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}