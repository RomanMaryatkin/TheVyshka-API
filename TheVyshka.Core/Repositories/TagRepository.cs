using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheVyshka.Core.EF;
using TheVyshka.Data.Converters;
using TheVyshka.Data.Dto;
using TheVyshka.Data.Entities;
using TheVyshka.Data.Repositories;

namespace TheVyshka.Core.Repositories
{
    public class TagRepository: ITagRepository
    {
        private readonly TheVyshkaContext _context;

        public TagRepository(TheVyshkaContext context)
        {
            _context = context;
        }
        
        public async Task<List<TagsDto>> GetAllAsync()
        {
            var tags = TagConverter.Convert(
                await _context.Tags.ToListAsync());
            
            foreach (var t in tags)
            {
                var posts = new List<Post>();
                var postTags = _context.PostTags.Where(p => p.TagId == t.Id).ToList();
                foreach (var p in postTags)
                {
                    posts.Add(_context.Posts.FirstOrDefault(u => u.Id == p.PostId));
                }
                t.Posts = posts;
            }
            
            return tags;
        }

        public async Task<TagsDto> GetByIdAsync(Guid id)
        {
            var tag = TagConverter.Convert(
                await _context.Tags.FindAsync(id));
            
            var posts = new List<Post>();
            var postTags = _context.PostTags.Where(p => p.TagId == tag.Id).ToList();
            foreach (var p in postTags)
            {
                posts.Add(_context.Posts.FirstOrDefault(u => u.Id == p.PostId));
            }
            tag.Posts = posts;
            
            return tag;
        }

        public async Task<TagsDto> CreateAsync(TagsDto item)
        {
            var tag = _context.Tags.Add(
                TagConverter.Convert(item));
            await _context.SaveChangesAsync();
            return TagConverter.Convert(tag.Entity);
        }

        public async Task<bool> UpdateAsync(TagsDto item)
        {
            if (item == null)
                return false;
            _context.Tags.Update(TagConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var tag = await _context
                .Tags
                .FindAsync(id);
            if (tag == null)
                return false;
            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}