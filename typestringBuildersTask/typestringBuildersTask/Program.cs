using System;
using typestringBuildersTask.Entities;

namespace typestringBuildersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that`s awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I`m going to visit this wondeful contry!",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            p1.AddComment(c3);
            p1.AddComment(c4);

            Console.WriteLine(p1);
            
        }
    }
}
