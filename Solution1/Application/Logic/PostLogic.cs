using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class PostLogic : IPostLogic
{
    private readonly IPostDao postDao;

    public PostLogic(IPostDao postDao)
    {
        this.postDao = postDao;
    }
    
    public async Task<Post> CreateAsync(PostCreationDto dto)
    {
        Post toCreate = new Post(dto.title,dto.body);

        Post created = await postDao.CreateAsync(toCreate);
    
        return created;
    }

    public Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        return postDao.GetAllPostsAsync();
    }
    
    public async Task<PostBasicDto> GetByIdAsync(int Id)
    {
        Post? post = await postDao.GetByIdAsync(Id);
        if (post == null)
        {
            throw new Exception($"Post with id {Id} not found");
        }

        return new PostBasicDto(post.Id, post.title, post.body);
    }
}