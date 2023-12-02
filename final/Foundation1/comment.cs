public class Comment
{   // A comment should be defined by the Comment class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
    private string commentText;
    private string commentor;

    public Comment(string commentor, string commentText){
        Console.WriteLine($"From {commentor},");
        Console.WriteLine(commentText);
    }

}