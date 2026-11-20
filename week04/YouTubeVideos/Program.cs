using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Getting Started with C#", "CodeWithAlex", 845);
        video1.AddComment(new Comment("Emma", "This cleared up a lot of confusion for me."));
        video1.AddComment(new Comment("Jake", "Really straightforward explanation."));
        video1.AddComment(new Comment("Priya", "Can you do one on lists next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Understanding Abstraction", "TechSimplified", 612);
        video2.AddComment(new Comment("Marcus", "Finally makes sense now."));
        video2.AddComment(new Comment("Sophie", "Great examples, thanks!"));
        video2.AddComment(new Comment("Liam", "I wish my class explained it like this."));
        video2.AddComment(new Comment("Ava", "Saved this one for later."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("YouTube Algorithm Tips", "GrowthLab", 1530);
        video3.AddComment(new Comment("Noah", "Tried a couple of these already."));
        video3.AddComment(new Comment("Olivia", "Very practical advice."));
        video3.AddComment(new Comment("Ethan", "Do you have data to back this up?"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Debugging Like a Pro", "DevDaily", 498);
        video4.AddComment(new Comment("Mia", "The breakpoint tip was gold."));
        video4.AddComment(new Comment("Lucas", "I always skip debugging videos but this one was solid."));
        video4.AddComment(new Comment("Zoe", "Thanks for keeping it short."));
        videos.Add(video4);

        // Display everything
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("  " + comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}