using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# abstract classes and methods in 8 minutes" , "tuorialsEU-C#" , 491 );
        Video video2 = new Video("57. (C# Basics Beginner Tutorial) Abstraction" , "Programming made EZ" , 739);
        Video video3 = new Video("What is Abstraction in C# .NET? How to implement abstraction in real applications?" , "Interview Happy" ,258);
        Video video4 = new Video("C# abstract classes" , "Bro Code" , 141);

        video1.Comments.Add(new Comment("Frank" ,"Thank you i had 4 hours of sleep and i needed to get some more abstact and interface info into my brain, and as it is this weeks class subject and im trying to cram it in there."));
        video1.Comments.Add(new Comment("Marcos" ,"Clarly explained. Thank you. Anyway, is this channel still active or do you move to the tutorialseu?"));
        video1.Comments.Add(new Comment("German" ,"Clear and fast! Thanks"));
        
        video2.Comments.Add(new Comment("Grant" ,"I dont understand"));
        video2.Comments.Add(new Comment("Josh" ,"Apreciate your work"));
        video2.Comments.Add(new Comment("Drake","great, thank you for your effort"));

        video3.Comments.Add(new Comment("Michel" ,"You are doing great work"));
        video3.Comments.Add(new Comment("James" ,"Sir you are grea"));
        video3.Comments.Add(new Comment("Heber" ,"Rawat ji you are great... keep it up."));

        video4.Comments.Add(new Comment("Brigham" , "your explanations are awesome"));
        video4.Comments.Add(new Comment("Thomas" ,"Brief, short, clear, concise, perfect!"));
        video4.Comments.Add(new Comment("Henry" ,"Excellent video. Concise and to the point."));
        
        List<Video> videos = new List<Video> { video1, video2, video3 ,video4 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Auhor: {video.Author}");
            Console.WriteLine($"Length in seconds: {video.LengthInSecond} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments");
            foreach (var comments in video.Comments)
            {
                Console.WriteLine($"{comments.CommenterName} : {comments.Text}");
            }
        }
    }
}