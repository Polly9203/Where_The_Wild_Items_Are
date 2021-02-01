using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Where_The_Wild_Items_Are.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string LinkToCreator { get; set; }
        public string Annotation { get; set; }
        public int NumberOfItem { get; set; }
        public string Text { get; set; }
        public string Tag { get; set; }
        public int Like { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public List<Comment> Comments { get; set; }

        public Collection() { }

        public Collection(string caption, string annotation, int numberOfItem, string tag, string text, string linkToCreator)
        {
            Caption = caption;
            Annotation = annotation;
            NumberOfItem = numberOfItem;
            Text = text;
            LinkToCreator = linkToCreator;
            Like = 0;
            Tag = tag;
            LastUpdateTime = DateTime.Now;
            Comments = new List<Comment>();
        }
    }
}