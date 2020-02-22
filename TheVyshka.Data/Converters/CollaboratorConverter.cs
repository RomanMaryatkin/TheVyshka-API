using System.Collections.Generic;
using System.Linq;
using TheVyshka.Data.Dto;
using TheVyshka.Data.Entities;

namespace TheVyshka.Data.Converters
{
    public static class CollaboratorConverter
    {
        public static Collaborator Convert(CollaboratorDto collaborator)
        {
            
            return new Collaborator
            {
                Id = collaborator.Id,
                Name = collaborator.Name,
                Date = collaborator.Date,
                Description = collaborator.Description,
                Links = collaborator.Links
            };
        }

        public static CollaboratorDto Convert(Collaborator collaborator)
        {
            
            return new CollaboratorDto
            {
                Id = collaborator.Id,
                Name = collaborator.Name,
                Date = collaborator.Date,
                Description = collaborator.Description,
                Links = collaborator.Links
            };
        }

        public static List<Collaborator> Convert(List<CollaboratorDto> collaborators)
        {
            return collaborators.Select(c => Convert(c)).ToList();
        }
        
        public static List<CollaboratorDto> Convert(List<Collaborator> collaborators)
        {
            return collaborators.Select(c => Convert(c)).ToList();
        }
    }
}