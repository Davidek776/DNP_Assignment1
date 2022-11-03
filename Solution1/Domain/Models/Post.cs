namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string title { get; }
    public string body { get; }
    

    public Post( string title, string body)
    {
        
        this.title = title;
        this.body = body;
    }
}