using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IPostLogic
{
    public Task<Post> CreateAsync(PostCreationDto postToCreate);
    public Task<IEnumerable<Post>> GetAllPostsAsync();

    
}