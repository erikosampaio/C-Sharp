using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessionPost.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<string> Comments { get; set; } = new List<string>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // public override string ToString()
        // {
        // return Title
        // + $"\n{Likes} Likes - "
        // + Moment.ToString()
        // + $"\n{Content}"
        // + "Comments:"
        // // + foreach(Comment comment in Comments)
        // {
        // Console.WriteLine(comment);
        // }
        // }
    }
}
