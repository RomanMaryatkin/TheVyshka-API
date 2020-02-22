using System;

namespace TheVyshka.Data.Entities
{
    public class PostPreview
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string Rubric { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string ImgLink { get; set; }
        public int ViewCount { get; set; }
    }
}