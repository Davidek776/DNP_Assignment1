using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace FileData.DAOs;

public class UserFileDao: IUserDao
{
    private readonly FileContext context;

    public UserFileDao(FileContext context)
    {
        this.context = context;
    }
    
    public Task<User> CreateAsync(User user)
    {
        // int userId = 1;
        // if (context.Users.Any())
        // {
        //     userId = context.Users.Max(u => u.Id);
        //     userId++;
        // }
        //
        // user.Id = userId;

        context.Users.Add(user);
        context.SaveChanges();

        return Task.FromResult(user);
    }
    
    
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters)
    {
        IEnumerable<User> result = context.Users.AsEnumerable();

        if (searchParameters.Username != null)
        {
            result = result.Where(user => user.UserName == searchParameters.Username);
        }
        
        if (searchParameters.password != null)
        {
            result = result.Where(user => user.password == searchParameters.password);
        }

        return Task.FromResult(result);
    }

    public Task<User?> GetByUsernameAsync(string userName)
    {
        User? existing = context.Users.FirstOrDefault(u =>
            u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
        );
        return Task.FromResult(existing);
    }
    
    
}