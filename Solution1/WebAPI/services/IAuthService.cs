
using Domain.DTOs;
using Domain.Models;

namespace WebAPI.services;

public interface IAuthService
{
    Task<User> ValidateUser(string username, string password);
    Task RegisterUser(UserRegisterDto userRegisterDto);
}