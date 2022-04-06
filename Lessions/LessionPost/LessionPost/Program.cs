using System;
using LessionPost.Entities;

namespace LessionPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment com1 = new Comment("Have a nice trip");
            Comment com2 = new Comment("Wow that's awesome!");

            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            post.Comments.Add(com1);
            post.Comments.Add(com2);

            //Segundo objeto
            Comment com3 = new Comment("Good night");
            Comment com4 = new Comment("May the Force be with you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            post2.Comments.Add(com3);
            post2.Comments.Add(com4);

            Console.WriteLine(post);
            Console.WriteLine(post2);
        }
    }
}
