using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> _videos = new List<Videos>();

        Videos video = new Videos("Astronomy", "Alice", 32);
        
        video.AddComment(new Comment("John", "The video is nice!"));
        video.AddComment(new Comment("Mary", "We would love more of this kind of video."));
        video.AddComment(new Comment("Jane", "Very informative video."));
        video.AddComment(new Comment("Dave", "The video is great!"));
        _videos.Add(video);
        

        Videos video1 = new Videos("Science", "Dawn morning", 70);
        video1.AddComment(new Comment("Justine", "Great work on this video!"));
        video1.AddComment(new Comment("James", "These videos are the best"));
        video1.AddComment(new Comment("Stephene", "I learnt a lot from this video."));
        video1.AddComment(new Comment("Emmanuella", "Could not ask for a better video!"));
        _videos.Add(video1);

        foreach (var vid in _videos)
        {
            vid.DisplayVideoInfo();
        }
        Console.WriteLine();
        
    }
}