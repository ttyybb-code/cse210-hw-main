using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title 1", "Channel 1", 1200);
        Video video2 = new Video("Title 2", "Channel 2", 12345);
        Video video3 = new Video("Title 3", "Channel 3", 1187);

        Comment Video1Comment1 = new Comment("Commenter1", "first");
        Comment Video1Comment2 = new Comment("Commenter2", "This video is 1200 seconds long");
        Comment Video1Comment3 = new Comment("Commenter3", "This is the Final Comment of Video 1");

        Comment Video2Comment1 = new Comment("Commenter1", "first");
        Comment Video2Comment2 = new Comment("Commenter2", "This video is 12345 seconds long");
        Comment Video2Comment3 = new Comment("Commenter3", "This is the final comment for video 2");

        Comment Video3Comment1 = new Comment("Commenter1", "first");
        Comment Video3Comment2 = new Comment("Commenter2", "This video is 1187 seconds long");
        Comment Video3Comment3 = new Comment("Commenter3", "This is the last comment for video 3");

        video1.AddComment(Video1Comment1);
        video1.AddComment(Video1Comment2);
        video1.AddComment(Video1Comment3);

        video2.AddComment(Video2Comment1);
        video2.AddComment(Video2Comment2);
        video2.AddComment(Video2Comment3);

        video3.AddComment(Video3Comment1);
        video3.AddComment(Video3Comment2);
        video3.AddComment(Video3Comment3);

        List<Video> videos = new List<Video>{video1, video2, video3};
        foreach(Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.ShowAllComments();
        }



    }
}