using System.Collections.Generic;
using System.Linq;
using TheVyshka.Data.Dto;
using TheVyshka.Data.Entities;

namespace TheVyshka.Data.Converters
{
    public static class TagConverter
    {
        public static Tags Convert(TagsDto tag)
        {
            
            return new Tags
            {
                Id = tag.Id,
                Name = tag.Name
            };
        }

        public static TagsDto Convert(Tags tag)
        {
            return new TagsDto
            {
                Id = tag.Id,
                Name = tag.Name
            };
        }

        public static List<Tags> Convert(List<TagsDto> tags)
        {
            return tags.Select(t => Convert(t)).ToList();
        }
        
        public static List<TagsDto> Convert(List<Tags> tags)
        {
            return tags.Select(t => Convert(t)).ToList();
        }
    }
}