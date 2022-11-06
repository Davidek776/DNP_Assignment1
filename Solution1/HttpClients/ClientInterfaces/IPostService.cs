using Domain.DTOs;
using Domain.Models;

namespace HttpClients.ClientInterfaces;

public interface IPostService
{
    Task<Post> Create(PostCreationDto dto);
    Task<ICollection<Post>> GetAllAsync(
        
    );
    Task<Post> GetSingleAsync(int id);
}