using System;
using Aula122.Entities;

namespace Aula122
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(DateTime.Now, "Traveling to New Zeland", "I'm going visit the wonderfull country!", 12);
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome");
            p1.AddComment(comment1);
            p1.AddComment(comment2);

            Post p2 = new Post(DateTime.Now, "Good night guys", "See you tomorrow", 5);
            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the Force be with you");
            p2.AddComment(comment3);
            p2.AddComment(comment4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
