using System.Transactions;

public class Video
{   // Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number of comments.
    private string title;
    private string author;
    private int length; // in seconds
    private List<Comment> commentsList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Console.WriteLine(title);
        Console.WriteLine($"By {author}");
        Console.WriteLine($"{length} seconds long.");
    }

    public int GetNumComments() // returns number of comments
    {
        int numComments = commentsList.Count();
        return numComments;
    }

    public void AddComment(Comment comment)
    {
        commentsList.Add(comment);
    }
}