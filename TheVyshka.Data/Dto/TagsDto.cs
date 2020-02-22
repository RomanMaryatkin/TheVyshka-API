using System;
using System.Collections.Generic;
using TheVyshka.Data.Entities;

namespace TheVyshka.Data.Dto
{
    public class TagsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts  { get; set; }
    }
}