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
    public class CollaboratorRepository: ICollaboratorRepository
    {
        private readonly TheVyshkaContext _context;

        public CollaboratorRepository(TheVyshkaContext context)
        {
            _context = context;
        }
        
        public async Task<List<CollaboratorDto>> GetAllAsync()
        {
            var collaborators = CollaboratorConverter.Convert(
                await _context.Collaborators.ToListAsync());
            
            foreach (var c in collaborators)
            {
                var posts = new List<Post>();
                var postCollaborators = _context.PostCollaborators.Where(p => p.CollaboratorId == c.Id).ToList();
                foreach (var p in postCollaborators)
                {
                    posts.Add(_context.Posts.FirstOrDefault(u => u.Id == p.PostId));
                }
                c.Posts = posts;
            }
            
            return collaborators;
        }

        public async Task<CollaboratorDto> GetByIdAsync(Guid id)
        {
            var collaborator = CollaboratorConverter.Convert(
                await _context.Collaborators.FindAsync(id));
            
            var posts = new List<Post>();
            var postCollaborators = _context.PostCollaborators.Where(p => p.CollaboratorId == collaborator.Id).ToList();
            foreach (var p in postCollaborators)
            {
                posts.Add(_context.Posts.FirstOrDefault(u => u.Id == p.PostId));
            }
            collaborator.Posts = posts;
            
            return collaborator;
        }

        public async Task<CollaboratorDto> CreateAsync(CollaboratorDto item)
        {
            var collaborator = _context.Collaborators.Add(
                CollaboratorConverter.Convert(item));
            await _context.SaveChangesAsync();
            return CollaboratorConverter.Convert(collaborator.Entity);
        }

        public async Task<bool> UpdateAsync(CollaboratorDto item)
        {
            if (item == null)
                return false;
            _context.Collaborators.Update(CollaboratorConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var collaborator = await _context
                .Collaborators
                .FindAsync(id);
            if (collaborator == null)
                return false;
            _context.Collaborators.Remove(collaborator);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}