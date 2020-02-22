using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheVyshka.Data.Dto;

namespace TheVyshka.Data.Repositories
{
    public interface IPostRepository
    {
        Task<List<PostDto>> GetAllAsync();
        Task<PostDto> GetByIdAsync(Guid id);
        Task<List<PostDto>> GetByRubricAsync(string rubric);
        Task<List<PostDto>> GetByCollaboratorAsync(string collaboratorName);
        Task<List<PostDto>> GetByTagAsync(string tagName);
        Task<List<PostDto>> GetByNameAsync(string name);
        Task<PostDto> CreateAsync(PostDto item);
        Task<bool> UpdateAsync(PostDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}