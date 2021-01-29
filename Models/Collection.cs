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
        //public string NameOfCreator { get; set; }
        public string Annotation { get; set; }
        public int NumberOfSpecialty { get; set; }
        public string Text { get; set; }
        public string Tag { get; set; }
        public int Like { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public List<Comment> Comments { get; set; }

        public Collection() { }

        public Collection(string caption, /*string nameOfCreator,*/ string annotation, int numberOfSpecialty, string text, string linkToCreator)
        {
            Caption = caption;
            //NameOfCreator = nameOfCreator;
            Annotation = annotation;
            NumberOfSpecialty = numberOfSpecialty;
            Text = text;
            LinkToCreator = linkToCreator;
            Like = 0;
            LastUpdateTime = DateTime.Now;
            Comments = new List<Comment>();
        }
    }
}