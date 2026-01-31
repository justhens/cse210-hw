using System;
using System.Collections.Generic;

class Program
{
 static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Best Street Tacos", "FoodVibes", 540);
        video1.AddComment(new Comment("Luis", "Now I'm hungry."));
        video1.AddComment(new Comment("Sarah", "That spot downtown is my favorite."));
        video1.AddComment(new Comment("Mike", "Tacos al pastor looked amazing."));

        Video video2 = new Video("Top 5 Budget Travel Destinations", "WanderMore", 780);
        video2.AddComment(new Comment("Emma", "Portugal is definitely underrated."));
        video2.AddComment(new Comment("Noah", "I went to Mexico last year and loved it."));
        video2.AddComment(new Comment("Ava", "Adding these to my travel list."));

        Video video3 = new Video("Building a Gaming PC", "TechBuilds", 920);
        video3.AddComment(new Comment("Chris", "That GPU setup was clean."));
        video3.AddComment(new Comment("Jordan", "Prices are finally reasonable again."));
        video3.AddComment(new Comment("Taylor", "This helped me pick my parts."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }
    }
}
