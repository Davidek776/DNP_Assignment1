namespace Domain.DTOs;

public class PostCreationDto
{
    // public int Id;
    public string title { get;}
    public string body { get;}

    public PostCreationDto(string title,string body)
    {
        this.title = title;
        this.body = body;
    }
}