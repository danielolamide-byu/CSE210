

using System.Dynamic;
using System.Net;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("MM-dd-yyy");
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{Date} Prompt: {Prompt}");
        Console.WriteLine($"Rresponse: {Response}");
        Console.Write("");
    }
}