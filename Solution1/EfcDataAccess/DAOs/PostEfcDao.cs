using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class PostEfcDao : IPostDao
{
    private readonly DBContext context;

    public PostEfcDao(DBContext context)
    {
        this.context = context;
    }
    public async Task<Post> CreateAsync(Post post)
    {
        EntityEntry<Post> added = await context.Posts.AddAsync(post);
        await context.SaveChangesAsync();
        return added.Entity;
    }
    
    public Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        IEnumerable<Post> posts = context.Posts.AsEnumerable();

        posts = context.Posts;
        

        return Task.FromResult(posts);
    }
    
    public async Task<Post?> GetByIdAsync(int Id)
    {
        Post? found = await context.Posts.FindAsync(Id);
        return found;
    }
}