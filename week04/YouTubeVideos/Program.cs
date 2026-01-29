using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to learn C#", "Daniel Américo", 600);
        Comment comment1 = new Comment("Maria", "Very good content!!!");
        Comment comment2 = new Comment("Gabriel", "Do you have any other hints?");
        Comment comment3 = new Comment("Luiz", "Could you make another one about this same topic?");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        videos.Add(video1);
 
        Video video2 = new Video("Cooking Wagyu with Daniel Americo chief", "Daniel Américo", 300);
        Comment comment4 = new Comment("Fred", "Very good");
        Comment comment5 = new Comment("Italo", "Do you have any other ?");
        Comment comment6 = new Comment("Jean", "Could you make another one about this?");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        videos.Add(video2);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine();
        }
    }
}