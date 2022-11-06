namespace Domain.DTOs;

public class PostBasicDto
{
    public int Id { get; set; }
    public string title { get; }
    public string body { get; }
    

    public PostBasicDto( int Id,string title, string body)
    {
        this.Id = Id;
        this.title = title;
        this.body = body;
    }
}