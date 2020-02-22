using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheVyshka.Data.Dto;

namespace TheVyshka.Data.Repositories
{
    public interface ICollaboratorRepository
    {
        Task<List<CollaboratorDto>> GetAllAsync();
        Task<CollaboratorDto> GetByIdAsync(Guid id);
        Task<CollaboratorDto> CreateAsync(CollaboratorDto item);
        Task<bool> UpdateAsync(CollaboratorDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}