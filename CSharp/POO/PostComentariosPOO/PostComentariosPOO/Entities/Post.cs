using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PostComentariosPOO.Entities;

namespace PostComentariosPOO.Entities
{
    internal class Post
    {
        public DateTime moment { get; private set; }
        public string title { get; private set; }
        public string content { get; private set; }
        public int likes { get; private set; }
        public List<Comment> list { get; private set; } = new List<Comment>();

        public Post(string title_, string content_, int likes_)
        {
            moment = DateTime.Now;
            title = title_;
            content = content_;
            likes = likes_;
        }

        public void AddComment(string comment, Comment comment1)
        {
            list.Add(comment1);
        }

        public override string ToString()
        {
            return "Moment: " + moment +
                "\nTitle: " + title +
                "\nContent: " + content +
                "\nLikes: " + likes+
                "\nComments: "+ list;
            
        }
    }
}
