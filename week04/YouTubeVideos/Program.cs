using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Learn C# in 10 Minutes";
        video1._author = "CodeMaster";
        video1._length = 600;

        video1._comments.Add(new Comment { _name = "John", _text = "Very helpful!" });
        video1._comments.Add(new Comment { _name = "Mary", _text = "Thanks for explaining clearly." });
        video1._comments.Add(new Comment { _name = "David", _text = "Great tutorial!" });

        Video video2 = new Video();
        video2._title = "Object-Oriented Programming";
        video2._author = "TechGuru";
        video2._length = 850;

        video2._comments.Add(new Comment { _name = "Sarah", _text = "This made OOP easy to understand." });
        video2._comments.Add(new Comment { _name = "Mike", _text = "Excellent examples!" });
        video2._comments.Add(new Comment { _name = "Ella", _text = "Very informative." });

        Video video3 = new Video();
        video3._title = "C# Classes and Objects";
        video3._author = "Programming Hub";
        video3._length = 720;

        video3._comments.Add(new Comment { _name = "Chris", _text = "Exactly what I needed." });
        video3._comments.Add(new Comment { _name = "Anna", _text = "Awesome lesson!" });
        video3._comments.Add(new Comment { _name = "James", _text = "Helped me with my assignment." });

        Video video4 = new Video();
        video4._title = "Learn Lists in C#";
        video4._author = "Code Academy";
        video4._length = 540;

        video4._comments.Add(new Comment { _name = "Peter", _text = "Lists finally make sense." });
        video4._comments.Add(new Comment { _name = "Grace", _text = "Very practical examples." });
        video4._comments.Add(new Comment { _name = "Daniel", _text = "Thanks for sharing!" });

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}