using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    private readonly IUserLogic userLogic;

    public UserController(IUserLogic userLogic)
    {
        this.userLogic = userLogic;
    }
    
    // [HttpPost]
    // public async Task<ActionResult<User>> CreateAsync([FromQuery] string? userName, [FromQuery] string? password)
    // {
    //     try
    //     {
    //         UserCreationDto dto = new UserCreationDto(userName, password);
    //         User user = await userLogic.CreateAsync(dto);
    //         return Created($"/users/{user.Id}", user);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         return StatusCode(500, e.Message);
    //     }
    // }
    
    // [HttpGet]
    // public async Task<ActionResult<User>> LoginAsync([FromQuery] string? userName, [FromQuery] string? password)
    // {
    //     try
    //     {
    //         SearchUserParametersDto parameters = new(userName, password);
    //         var user = await userLogic.GetAsync(parameters);
    //         return Ok(user);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         return StatusCode(500, e.Message);
    //     }
    // }
    
}
