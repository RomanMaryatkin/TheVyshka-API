using System.Collections.Generic;
using System.Linq;
using TheVyshka.Data.Dto;
using TheVyshka.Data.Entities;

namespace TheVyshka.Data.Converters
{
    public static class PostConverter
    {
        public static Post Convert(PostDto post)
        {
            
            return new Post
            {
                Id = post.Id,
                Title = post.Title,
                Rubric = post.Rubric,
                Description = post.Description,
                Size = post.Size,
                DateTime = post.DateTime,
                ImgLink = post.ImgLink,
                TrackLink = post.TrackLink,
                Text = post.Text,
                TextHtml = post.TextHtml,
                ViewCount = post.ViewCount
            };
        }

        public static PostDto Convert(Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Rubric = post.Rubric,
                Description = post.Description,
                Size = post.Size,
                DateTime = post.DateTime,
                ImgLink = post.ImgLink,
                TrackLink = post.TrackLink,
                Text = post.Text,
                TextHtml = post.TextHtml,
                ViewCount = post.ViewCount
            };
        }

        public static List<Post> Convert(List<PostDto> posts)
        {
            return posts.Select(p => Convert(p)).ToList();
        }
        
        public static List<PostDto> Convert(List<Post> posts)
        {
            return posts.Select(p => Convert(p)).ToList();
        }
    }
}