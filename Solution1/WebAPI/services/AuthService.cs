using System.ComponentModel.DataAnnotations;
using Domain.DTOs;
using Domain.Models;
using HttpClients.ClientInterfaces;
using HttpClients.Implementations;


namespace WebAPI.services;

public class AuthService : IAuthService
{

    private IEnumerable<User> users;

    private readonly IUserService userService = new UserHttpClient(new HttpClient());

    // public AuthService(IUserService userService)
    // {
    //     this.userService = userService;
    // }
    

    public async Task<User> ValidateUser(string username, string password)
    {

        users = await userService.GetUsers();

        User? existingUser = users.FirstOrDefault(u =>
            u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));

        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return await Task.FromResult(existingUser);
    }

  

    public Task RegisterUser(User user)
    {

        // if (string.IsNullOrEmpty(user.UserName))
        // {
        //     throw new ValidationException("Username cannot be null");
        // }
        //
        // if (string.IsNullOrEmpty(user.password))
        // {
        //     throw new ValidationException("Password cannot be null");
        // }
        // // Do more user info validation here
        //
        // // save to persistence instead of list
        //
        // users.Add(user);
        
        return Task.CompletedTask;
    }
    
   
    
    
}