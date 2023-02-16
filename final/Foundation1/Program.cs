using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video Video1 = new Video("first Video", "Oliverio Cameron", 20);
        Video1.addComment(new Comment("Oliver Dusting","first video is amazing"));
        Video1.addComment(new Comment("Analy Cameron","I love this video"));
        Video1.addComment(new Comment("Roberto Cameron","I love this video"));
        Video1.addComment(new Comment("LAura Cameron","I love this video"));
        videos.Add(Video1);
        
        Video Video2 = new Video("Second Video", "Jesica Rodriguez", 120);
        Video2.addComment(new Comment("Oliver Dusting","first video is amazing"));
        Video2.addComment(new Comment("Analy Cameron","I love this video"));
        Video2.addComment(new Comment("Roberto Cameron","I love this video"));
        Video1.addComment(new Comment("LAura Cameron","Congratulations my friends"));
        videos.Add(Video2);

        Video Video3 = new Video("Third Video", "joicibet Dias", 300);
        Video3.addComment(new Comment("Oliver Dusting","first video is amazing"));
        Video3.addComment(new Comment("Analy Cameron","I love this video"));
        Video3.addComment(new Comment("Roberto Cameron","I love this video"));
        Video3.addComment(new Comment("LAura Cameron","I love this video"));
        videos.Add(Video3);

        Console.WriteLine("This is the list of videos:");
        Console.WriteLine();

        foreach(Video video in videos)
        {
        Console.WriteLine($"Tittle: {video.setTittle()}");
        Console.WriteLine($"Author: {video.setAuthor()}");
        Console.WriteLine($"Duration: {video.setDuration()} minutes");
        Console.WriteLine($"Number of comments: {video.numberOfComments()}");
            
        foreach(Comment comment in video.getComment())
            {
                comment.DisplayComment();
            }

        }
        
        
    }
}