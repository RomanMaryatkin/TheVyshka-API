using TheVyshka.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TheVyshka.Core.EF
{
    public class TheVyshkaContext : DbContext
    {
        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostPreview> PostPreviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<PostCollaborator> PostCollaborators { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        
        public TheVyshkaContext(DbContextOptions<TheVyshkaContext> opt): base(opt)
        {
            Database.EnsureCreated();
        }
    }
}