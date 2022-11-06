using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController: ControllerBase
{
    private readonly IPostLogic postLogic;

    public PostController(IPostLogic postLogic)
    {
        this.postLogic = postLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult<Post>> CreateAsync(PostCreationDto dto)
    {
        try
        {
            // PostCreationDto dto = new PostCreationDto(title, body);
            Post post = await postLogic.CreateAsync(dto);
            return Created($"/posts/{post.Id}", post);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllPostsAsync()
    {
        try
        {
            IEnumerable<Post> posts = await postLogic.GetAllPostsAsync();
            return Ok(posts);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet("{Id:int}")]
    public async Task<ActionResult<Post>> GetById([FromRoute] int Id)
    {
        try
        {
            PostBasicDto result = await postLogic.GetByIdAsync(Id);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}

