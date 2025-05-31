
using Microsoft.Win32.SafeHandles;

public class Videos
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();

    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public int NumberOfComment()
    {
        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}.");
        Console.WriteLine($"Author: {_author}.");
        Console.WriteLine($"Length: {_length} seconds.");
        Console.WriteLine($"Number of Comments: {NumberOfComment()}.");
        Console.WriteLine("");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommentText()}");
        }
        Console.WriteLine();
    }

    
    

    
}