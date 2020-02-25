using System;
using System.Collections.Generic;
using TheVyshka.Data.Entities;

namespace TheVyshka.Data.Dto
{
    public class PostDto
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
        public List<CollaboratorDto> Collaborators { get; set; }
        public List<TagsDto> Tags { get; set; }
    }
}