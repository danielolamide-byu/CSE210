using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the class
        NoteBook myNotebook = new NoteBook();

        // Add some sentences
        myNotebook.AddSentence("This is my first note.");
        myNotebook.AddSentence("C# is fun!");
        myNotebook.AddSentence("I'm learning how to use lists in a class.");

        // Show all the sentences
        myNotebook.DisplaySentences();
    }
}
