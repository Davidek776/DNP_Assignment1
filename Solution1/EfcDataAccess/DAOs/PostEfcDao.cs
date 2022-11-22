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

    // public async Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParameters)
    // {
    //     IQueryable<Post> query = context.Posts.Include(post => post.Id).AsQueryable();
    //
    //     if (!string.IsNullOrEmpty(searchParams.Username))
    //     {
    //         // we know username is unique, so just fetch the first
    //         query = query.Where(todo =>
    //             todo.Owner.UserName.ToLower().Equals(searchParams.Username.ToLower()));
    //     }
    //
    //     if (searchParams.UserId != null)
    //     {
    //         query = query.Where(t => t.Owner.Id == searchParams.UserId);
    //     }
    //
    //     if (searchParams.CompletedStatus != null)
    //     {
    //         query = query.Where(t => t.IsCompleted == searchParams.CompletedStatus);
    //     }
    //
    //     if (!string.IsNullOrEmpty(searchParams.TitleContains))
    //     {
    //         query = query.Where(t =>
    //             t.Title.ToLower().Contains(searchParams.TitleContains.ToLower()));
    //     }
    //
    //     List<Todo> result = await query.ToListAsync();
    //     return result;
    // }
    
    public Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        throw new NotImplementedException();
    }
    
    public async Task<Post?> GetByIdAsync(int Id)
    {
        Post? found = await context.Posts.FindAsync(Id);
        return found;
    }
}