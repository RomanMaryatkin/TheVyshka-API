using System;

namespace TheVyshka.Data.Entities
{
    public class PostCollaborator
    {
        public Guid CollaboratorId { get; set; }
        public Guid PostId { get; set; }
        public string Role { get; set; }
    }
}