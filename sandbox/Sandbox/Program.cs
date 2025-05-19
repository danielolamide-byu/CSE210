using System;
using System.Collections.Generic;

public class NoteBook
{
    // A list to hold the sentences
    public List<string> Sentences = new List<string>();

    // Method to add a sentence to the list
    public void AddSentence(string sentence)
    {
        Sentences.Add(sentence);
    }

    // Method to display all sentences
    public void DisplaySentences()
    {
        Console.WriteLine("Sentences in the notebook:");
        foreach (string s in Sentences)
        {
            Console.WriteLine("- " + s);
        }
    }
}
