using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface IPostDao
{
    Task<Post> CreateAsync(Post post);
    
    Task<Post?> GetByPostIdAsync(int id);
    Task<IEnumerable<Post>> GetAllPostsAsync();

}