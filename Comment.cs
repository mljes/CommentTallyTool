using System;
using System.Collections.Generic;
using System.Text;

namespace CommentTallyTool
{
    class Comment
    {
        public string Body { get; set; }
        public int Count { get; set; }
        public bool Copied { get; set; }

        public Comment(string text, int count)
        {
            Body = text;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Body}";
        }
    }
}
