using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string Title;
    public string Author;
    public int LengthInSecond;
    public List<Comment> Comments;  

    public Video(string title , string author, int lengthInSecond)
    {
        Title = title;
        Author = author;
        LengthInSecond = lengthInSecond;
        Comments = new List<Comment>();
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}