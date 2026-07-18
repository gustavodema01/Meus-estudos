using System;

namespace PostComentariosPOO.Entities
{
    internal class Comment
    {
        public string text{ get; private set; }

        public Comment(string text_)
        {
            text = text_;
        }
    }
}
