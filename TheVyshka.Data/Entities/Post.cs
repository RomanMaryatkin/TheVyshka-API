using System;
using System.Collections.Generic;

namespace TheVyshka.Data.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Rubric { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public DateTime DateTime { get; set; }
        public string ImgLink { get; set; }
        public string TrackLink { get; set; }
        public string Text { get; set; }
        public string TextHtml { get; set; }
        public int ViewCount { get; set; }
        // public List<PostCollaborator> PostCollaborator { get; set; }
        // public List<PostTag> PostTag { get; set; }
    }
}