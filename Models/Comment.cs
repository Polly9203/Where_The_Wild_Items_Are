using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Where_The_Wild_Items_Are.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CreatorName { get; set; }
        public int ParentCommentId { get; set; }
        public int Like { get; set; }
        public DateTime CreationTime { get; set; }
        public Collection Collection { get; set; }

        public Comment() { }

        public Comment(string creatorName, int parentCommentId, Collection collection, string text)
        {
            CreationTime = DateTime.Now;
            Like = 0;
            CreatorName = creatorName;
            ParentCommentId = parentCommentId;
            Collection = collection;
            Text = text;
        }
    }
}