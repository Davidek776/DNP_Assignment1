﻿using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace WebAPI.services;

public class AuthService : IAuthService
{
    
    private readonly IList<User> users = new List<User>()
    {
        new User("admin","adminpassword"),
        new User("user","userpassword")
    };
    

    

    public Task<User> ValidateUser(string username, string password)
    {
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

        return Task.FromResult(existingUser);
    }

  

    public Task RegisterUser(User user)
    {

        if (string.IsNullOrEmpty(user.UserName))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(user.password))
        {
            throw new ValidationException("Password cannot be null");
        }
        // Do more user info validation here
        
        // save to persistence instead of list
        
        users.Add(user);
        
        return Task.CompletedTask;
    }
    
    public Task<User> GetUser(string username, string password)
    {
        throw new NotImplementedException();
    }
    
    
}