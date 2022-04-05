using System;
using LessionPost.Entities;

namespace LessionPost
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = "Traveling to New Zealand";
            int likes = 12;
            DateTime data = DateTime.Parse("21/06/2018 13:05:44");
            string content = "I'm going to visit this wonderful country!";
            
            Post post = new Post(data, title, content, likes);

            string com1 = "Have a nice trip";
            string com2 = "Wow that's awesome!";
            post.Comments.Add(com1);
            post.Comments.Add(com2);

            Console.WriteLine(post.Title);
            Console.WriteLine($"{post.Likes} Likes - {post.Moment}");
            Console.WriteLine(post.Content);
            Console.WriteLine("Comments:");
            foreach (string comment in post.Comments)
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
            //Segundo objeto

            string title2 = "Good night guys";
            int likes2 = 5;
            DateTime data2 = DateTime.Parse("28/07/2018 23:14:19");
            string content2 = "See you tomorrow";

            Post post2 = new Post(data2, title2, content2, likes2);

            string com3 = "Good night";
            string com4 = "May the Force be with you";
            post2.Comments.Add(com3);
            post2.Comments.Add(com4);

            Console.WriteLine(post2.Title);
            Console.WriteLine($"{post2.Likes} Likes - {post2.Moment}");
            Console.WriteLine(post2.Content);
            Console.WriteLine("Comments:");
            foreach (string comment in post2.Comments)
            {
                Console.WriteLine(comment);
            }
        }
    }
}
