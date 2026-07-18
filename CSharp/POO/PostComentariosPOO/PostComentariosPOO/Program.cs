using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostComentariosPOO.Entities;

namespace PostComentariosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Console.Write("Likes: ");
            int likes = int.Parse(Console.ReadLine());
            Post post = new Post(title, content, likes);
            Console.Write("How many comments should be inserted?: ");
            int qtdComment = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdComment; i++)
            {
                Console.Write($"\nComment #{i+1}: ");
                string comment = Console.ReadLine();
                Comment comment_ = new Comment(comment);
                post.AddComment(comment, comment_);
            }
            Console.WriteLine(post);


        }
    }
}
