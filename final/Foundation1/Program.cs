using System;

class Program
{   // Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
    static void Main(string[] args)
    {
        Console.WriteLine("------------------");
        Video video1 = new Video("test title", "joe", 3);
        Console.WriteLine("------------------");
        Comment comment1 = new Comment("John", "nice vid boi!");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("Jay", "Sweet.");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("Susie", "great");
        video1.AddComment(comment3);
        Console.WriteLine($"{video1.GetNumComments()} comments");

        Console.WriteLine("------------------");
        Video video2 = new Video("test 2", "joe", 178);
        Console.WriteLine("------------------");
        Comment comment4 = new Comment("Napoleon Dynamite", "Dude, that SUCKS- I could do it better in my sleep!");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("ThePianoGuys", "Nice use of the strings! We will have to try that.");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Kris", "...");
        video2.AddComment(comment6);
        Console.WriteLine($"{video2.GetNumComments()} comments");

        Console.WriteLine("------------------");
        Video video3 = new Video("Music Video", "John Cena", 55000);
        Console.WriteLine("------------------");
        Comment comment7 = new Comment("Taylor Swift", "I love the part at 2:31");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("Your Mama", "Get off the computer, Johnny!");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("Wheatley", "Ha! You're in TROUBLEEE!!");
        video3.AddComment(comment9);
        Console.WriteLine($"{video3.GetNumComments()} comments");

        Console.WriteLine("------------------");
        Video video4 = new Video("How I ACTUALLY Shrunk the Moon", "Mark Roper", 16030);
        Console.WriteLine("------------------");
        Comment comment10 = new Comment("DanTDM", "I haven't even done that in minecraft, and I thought I did EVERYTHING! XD");
        video4.AddComment(comment10);
        Comment comment11 = new Comment("Gabe the Dog", "Bork Bork, Grr Bork!");
        video4.AddComment(comment11);
        Comment comment12 = new Comment("Allan the Alien", "ü}Ω╙σ☻58☺╡/)═P◙Ð/╣☻Uk2ÅKA  ╪2#20↓@enderdrangoon");
        video4.AddComment(comment12);
        Console.WriteLine($"{video4.GetNumComments()} comments");

        Console.WriteLine("");
        Console.WriteLine("END RESULTS.");
    }
}